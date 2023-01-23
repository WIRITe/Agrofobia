using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delay : MonoBehaviour
{
    public GameObject ObjectForDely;

    public float DelyTime;
    private float Timer;

    // Update is called once per frame
    public void Update()
    {
        if(Timer >= DelyTime)
        {
            ObjectForDely.SetActive(true);
        }
        else
        {
            Timer = Time.deltaTime;
        }
    }
}
