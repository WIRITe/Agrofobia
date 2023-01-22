using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScrimer : MonoBehaviour
{
    public GameObject[] Light;

    public bool first = true;
    public bool TriggerWas;

    public float Timer;
    public float TimeTo;

    private void Update()
    {
        if (TriggerWas)
        {
            if (Timer >= TimeTo)
            {
                Turn(true);
                Timer = 0;
            }
            else
            {
                Timer += Time.deltaTime;
            }
        }
    }

    public void OnTriggerEnter()
    {
        if (first) { Turn(false); TriggerWas = true; TimeTo = 5; first = false; }
    }

    public void Turn(bool B)
    {
        for(int i = 0; i < Light.Length; i++)
        {
            Light[i].gameObject.SetActive(B);
        }
    }
}
