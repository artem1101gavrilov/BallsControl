using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleMove : MonoBehaviour {

    //X от -15 до 14
    //У от -11 до 8
    private Vector3 currentPoint;

    private void Start()
    {
        currentPoint = new Vector3(Random.Range(-15, 15), Random.Range(-11, 8), -2);
    }

    void Update () {
        if(Vector3.Distance(transform.position, currentPoint) < 1)
        {
            currentPoint = new Vector3(Random.Range(-15, 15), Random.Range(-11, 8), -2);
        }
        transform.position = Vector3.MoveTowards(transform.position, currentPoint, 2 * Time.deltaTime);
    }
}
