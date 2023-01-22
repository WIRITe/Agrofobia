using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMAnag : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void OnSiteClick()
    {
        System.Diagnostics.Process.Start("https://erer23fgfdf54wffgrrtg3.on.drv.tw/MySite/main.html");
    }

    public void OnPlayClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void OnQuitClick()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
