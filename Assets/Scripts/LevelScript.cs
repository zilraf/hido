using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelScript : MonoBehaviour {

    public int TotalScore;
    public int Score;
    //public Transform NextScene;
    //public bool MainMenu;
    //public Timer TimeScript;

    //temporary
    public string NamaScene;

	// Use this for initialization
	void Start () {
        Score = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (Score == TotalScore) {
                
                SceneManager.LoadScene(NamaScene);
          
                //kalo mau spawn level baru
                //Instantiate(NextScene);
                Destroy(gameObject);
            

        }
	}


}
