using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tapd : MonoBehaviour {

    public LevelScript LevelMaster;

    public static string objname;
    public GameObject objtext;
    public Transform tapconfirm;

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

        Destroy(gameObject);
        Destroy(objtext);


        tapcount.taptot = 0;
        Instantiate (tapconfirm, objtext.transform.position, tapconfirm.rotation);
    }

}
