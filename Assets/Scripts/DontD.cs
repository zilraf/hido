using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontD : MonoBehaviour {

    public static DontD instance;

    private void Awake()
    {

        DontDestroyOnLoad(this);

        if (instance == null)
        {
            instance = this;
        }
        else
        {
            DestroyObject(gameObject);
        }
    }
}
