using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputName : MonoBehaviour {

    //kenapa script ini bisa ke run???
    public void GetInput(string uname)
    {
        Debug.Log("" + uname);
        PlayerPrefs.SetString("Username", uname);
    }

}
