using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCreator : MonoBehaviour {
    public LevelSelect asd;
    public Transform[] PrefabLevel;
	// Use this for initialization
	void Start () {
        asd = GameObject.Find("LevelSelect").GetComponent<LevelSelect>();
        if(asd.nomorlevel == 1){
            Instantiate(PrefabLevel[0]);
        }
        else{
            Instantiate(PrefabLevel[1]);
        }
	}
	
}
