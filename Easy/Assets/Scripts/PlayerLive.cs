using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLive : MonoBehaviour
{

    public GameObject Canv;

    public static bool isLive = true;

    // Update is called once per frame
    void Update()
    {
        if(!isLive) 
        {
            Time.timeScale = 0;
            Canv.SetActive(true);
        }
    }
}
