using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToNextLocation : MonoBehaviour
{
    public int indexOfScene;

    public Transform PosToTeleport;

    public bool IsDoorBlocked = false;

    public enum TypeOfGoingToNextScene
    {
        Teleport, 
        GoToNextScene
    }

    public TypeOfGoingToNextScene HowGoToNextScene = TypeOfGoingToNextScene.Teleport;

    public void OnTriggerEnter(Collider other)
    {
        if (!IsDoorBlocked)
        {
            if (other.tag == "Player")
            {
                if (HowGoToNextScene == TypeOfGoingToNextScene.GoToNextScene)
                {
                    goToNextLocation();
                }
                else
                {
                    other.transform.position = PosToTeleport.position;
                }
            }
        }
    }

    public void goToNextLocation()
    {
        SceneManager.LoadScene(indexOfScene);
    }
}
