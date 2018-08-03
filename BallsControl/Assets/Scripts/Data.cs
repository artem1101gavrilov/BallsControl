using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour {

    public GameObject ArrayCircles;

    public UnityEngine.UI.Button button1;
    public UnityEngine.UI.Button button2;
    public UnityEngine.UI.Button button3;

    private int numberForButton1;
    private int numberForButton2;
    private int numberForButton3;

    // Use this for initialization
    void Start () {
        numberForButton1 = 10;
        numberForButton2 = 20;
        numberForButton3 = 30;
        button1.gameObject.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text = numberForButton1.ToString();
        button2.gameObject.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text = numberForButton2.ToString();
        button3.gameObject.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text = numberForButton3.ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public  void PressButton1()
    {
        for(int i = 0; i < ArrayCircles.transform.childCount; i++)
        {
            ArrayCircles.transform.GetChild(i).GetComponent<CircleMove>().currentPoint = button1.transform.GetChild(1).transform.position;
            ArrayCircles.transform.GetChild(i).GetComponent<CircleMove>().finishPoint = true;
            ArrayCircles.transform.GetChild(i).GetComponent<CircleMove>().IDfinishPoint = 1;
        }
    }

    public void PressButton2()
    {
        for (int i = 0; i < ArrayCircles.transform.childCount; i++)
        {
            ArrayCircles.transform.GetChild(i).GetComponent<CircleMove>().currentPoint = button2.transform.GetChild(1).transform.position;
            ArrayCircles.transform.GetChild(i).GetComponent<CircleMove>().finishPoint = true;
            ArrayCircles.transform.GetChild(i).GetComponent<CircleMove>().IDfinishPoint = 2;
        }
    }

    public void PressButton3()
    {
        for (int i = 0; i < ArrayCircles.transform.childCount; i++)
        {
            ArrayCircles.transform.GetChild(i).GetComponent<CircleMove>().currentPoint = button3.transform.GetChild(1).transform.position;
            ArrayCircles.transform.GetChild(i).GetComponent<CircleMove>().finishPoint = true;
            ArrayCircles.transform.GetChild(i).GetComponent<CircleMove>().IDfinishPoint = 3;
        }
    }

    public void MinusNumber(int IDButton)
    {
        switch (IDButton)
        {
            case 1:
                numberForButton1--;
                if (numberForButton1 <= 0) Destroy(button1.gameObject);
                else button1.gameObject.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text = numberForButton1.ToString();
                break;
            case 2:
                numberForButton2--;
                if (numberForButton2 <= 0) Destroy(button2.gameObject);
                else button2.gameObject.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text = numberForButton2.ToString();
                break;
            case 3:
                numberForButton3--;
                if (numberForButton3 <= 0) Destroy(button3.gameObject);
                else button3.gameObject.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text = numberForButton3.ToString();
                break;
        }
    }
}
