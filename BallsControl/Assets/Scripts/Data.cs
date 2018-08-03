using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour {

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
        numberForButton1--;
        if (numberForButton1 <= 0) Destroy(button1.gameObject);
        else button1.gameObject.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text = numberForButton1.ToString();
    }

    public void PressButton2()
    {
        numberForButton2--;
        if (numberForButton2 <= 0) Destroy(button2.gameObject);
        else button2.gameObject.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text = numberForButton2.ToString();
    }

    public void PressButton3()
    {
        numberForButton3--;
        if (numberForButton3 <= 0) Destroy(button3.gameObject);
        else button3.gameObject.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text = numberForButton3.ToString();
    }
}
