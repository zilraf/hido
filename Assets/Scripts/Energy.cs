using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Energy : MonoBehaviour {

    public int energyLeft = 5;
    public Text energyText;


    // Use this for initialization
    void Awake () {
        //energyText = GameObject.Find("energy").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        energyText = GameObject.Find("energy").GetComponent<Text>();
        energyText.text = ("Energy: " + energyLeft);
    }

}
