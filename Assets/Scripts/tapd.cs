using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tapd : MonoBehaviour {

    public static string objname;
    public GameObject objtext;
    public Transform objtextpos;
    public Transform tapconfirm;
    //public static int gameObject = 5;

    public static int remainrectangle = 2;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {

        objname = gameObject.name;

        //RECTANGLE

        if ((gameObject.name == "rectangle") && (remainrectangle > 1))
        {
            remainrectangle -= 1;
            objtext.GetComponent<TextMesh> ().text = "rectangle " + remainrectangle;
            //Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
            Destroy(objtext);
            //gameObject -=1;
        }

  
        Destroy(gameObject);
        Destroy(objtext);
        //gameObject -=1;
       


        tapcount.taptot = 0;
        Instantiate (tapconfirm, objtextpos.transform.position, tapconfirm.rotation);
    }

}
