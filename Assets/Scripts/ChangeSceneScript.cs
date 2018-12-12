using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneScript : MonoBehaviour
{
    public string SceneName;
    public int nomorlevel;
    public LevelSelect LVLSLCT;
    public Energy enrg;
    

    public void Start()
    {
        LVLSLCT = GameObject.Find("LevelSelect").GetComponent<LevelSelect>();
        enrg = GameObject.Find("LevelSelect").GetComponent<Energy>();
    }

    public void ChangeScene(string SceneName)
    {
        //LVLSLCT.nomorlevel = nomorlevel;
        SceneManager.LoadScene(SceneName);
    }

    public void SelectLevel()
    {
        LVLSLCT.nomorlevel = nomorlevel;
        SceneManager.LoadScene(SceneName);
    }

    public void DecreaseEnergy()
    {
        enrg.energyLeft -= 1;
    }

    public void IncreaseEnergy()
    {
        enrg.energyLeft += 1;
    }
}
