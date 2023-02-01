using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject PauseWindow;

    public string StringOfPasc;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseWindow.SetActive(true);
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.Confined;

        }
    }

    public void OnReturnToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void OnReturnButtonPres()
    {
        PauseWindow.SetActive(false);
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void OnExitButtonPres()
    {
        Application.Quit();
    }

    public void OnClearPascPress()
    {
        PlayerPrefs.SetString(StringOfPasc, "");
    }
}
