using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tapcount : MonoBehaviour {

    public static int taptot = 0;
    public KeyCode screentap;
    public Timer TimeScript;

	// Use this for initialization
	void Start () {
        TimeScript = GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>();
	}

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(screentap))
        {
            taptot += 1;

        }
        if (taptot >= 3)
        {
            Debug.Log("Jangan SPAM!");
            //timeLeft -=1; //Penalty condition
            TimeScript.timeLeft -= 2;
            taptot = 0;
        }
	}
}
