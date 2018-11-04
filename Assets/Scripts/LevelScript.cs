using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelScript : MonoBehaviour {

    public int TotalScore;
    public int Score;
    public Transform NextLevel;
    public bool MainMenu;

    //temporary
    public string NamaScene;

	// Use this for initialization
	void Start () {
        Score = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (Score == TotalScore) {
            //kalo mau pindah scene
            if (MainMenu == true)
            {
                SceneManager.LoadScene(NamaScene);
            }
            else
            {
                //kalo mau spawn level baru
                Instantiate(NextLevel);
                Destroy(gameObject);
            }

        }
	}


}
