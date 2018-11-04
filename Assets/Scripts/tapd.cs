using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tapd : MonoBehaviour {

    public LevelScript LevelMaster;

    public static string objname;
    public GameObject objtext;
    public Transform tapconfirm;
    //public static int gameObject = 5;

    public static int remainrectangle = 2;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update ()
    {
        LevelMaster = GameObject.FindGameObjectWithTag("LevelMaster").GetComponent<LevelScript>();
    }

    void OnMouseDown()
    {

        objname = gameObject.name;
        LevelMaster.Score++;
        //RECTANGLE

        Destroy(gameObject);
        Destroy(objtext);
        //gameObject -=1;
       


        tapcount.taptot = 0;
        Instantiate (tapconfirm, objtext.transform.position, tapconfirm.rotation);
    }

}
