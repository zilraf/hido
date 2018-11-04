using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tapcount : MonoBehaviour {

    public static int taptot = 0;
    public KeyCode screentap;

	// Use this for initialization
	void Start () {
		
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
            taptot = 0;
        }
	}
}
