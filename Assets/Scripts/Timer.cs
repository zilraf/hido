using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public int timeLeft = 90;
    public Text countdownText;
    public GameObject GameOver;
    public string NamaScene;
    public cameraMovement MainCameraMov;

    public GameObject[] Tapdlistg;
    public bool TimerOn;

    // Use this for initialization
    void Start()
    {
        StartCoroutine("LoseTime");
        MainCameraMov = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<cameraMovement>();

        Tapdlistg = GameObject.FindGameObjectsWithTag("Object");
        TimerOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        countdownText.text = ("" + timeLeft);

        if (timeLeft <= 0 && TimerOn==true)
        {
            StopCoroutine("LoseTime");
            countdownText.text = "Time's Up!";
            GameOver.SetActive(true);
            MainCameraMov.enabled = false;
            for (int i = 0; i < Tapdlistg.Length;i++){
                Tapdlistg[i].GetComponent<tapd>().SendMessageUpwards("removeThisScript");
            }
            //SceneManager.LoadScene(NamaScene);
            TimerOn = false;
        }
            
    }

    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
        }
    }
}
