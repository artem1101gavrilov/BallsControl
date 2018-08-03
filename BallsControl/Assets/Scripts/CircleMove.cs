using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleMove : MonoBehaviour {

    //X от -15 до 14
    //У от -11 до 8
    public Vector3 currentPoint;
    public bool finishPoint;
    public int IDfinishPoint;
    private Data data;

    private void Start()
    {
        data = GameObject.Find("Data").GetComponent<Data>();
        transform.position = new Vector3(Random.Range(-15, 15), Random.Range(-11, 8), -2);
        currentPoint = new Vector3(Random.Range(-15, 15), Random.Range(-11, 8), -2);
        finishPoint = false;
    }

    void Update () {
        if(Vector3.Distance(transform.position, currentPoint) < 1)
        {
            if (finishPoint)
            {
                data.MinusNumber(IDfinishPoint);
                Destroy(gameObject);
            }
            else currentPoint = new Vector3(Random.Range(-15, 15), Random.Range(-11, 8), -2);
        }
        transform.position = Vector3.MoveTowards(transform.position, currentPoint, 5 * Time.deltaTime);
    }
}
