using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class TriggerActive : MonoBehaviour
{
    public GameObject[] Seting_Active;

    public GameObject TaskOld;
    public GameObject TaskNew;


    public GameObject[] Seting_Off;

    public bool OffOnExit = true;

    public bool once;
    public bool First = true;

    public bool DoNeedToTurnOff = true;

    public bool Music;

    public AudioSource audio;
    public AudioClip Musicc;

    public bool TurnOffRightAfter;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if(once) 
            { 
                if (First)
                {
                    for (int i = 0; i < Seting_Active.Length; i++)
                    {
                        Seting_Active[i].SetActive(OffOnExit);
                    }

                    if(TurnOffRightAfter)
                    {
                        for (int i = 0; i < Seting_Off.Length; i++)
                        {
                            Seting_Off[i].SetActive(!OffOnExit);
                        }
                    }

                    First= false;
                    if (Music)
                    {
                        audio.PlayOneShot(Musicc);
                    }
                }
            }
            else
            {
                for (int i = 0; i < Seting_Active.Length; i++)
                {
                    Seting_Active[i].SetActive(OffOnExit);
                }
                if (Music)
                {
                    audio.PlayOneShot(Musicc);
                }
            }
            
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player" && DoNeedToTurnOff)
        {
            if (!TurnOffRightAfter)
            {
                for (int i = 0; i < Seting_Off.Length; i++)
                {
                    Seting_Off[i].SetActive(!OffOnExit);
                }
            }
        }
    }
}
