using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DescTrigger : MonoBehaviour
{
    public GameObject scrPrsF;
    public int IndexNextLocation;

    public GameObject Scrtrtrt;
    public GameObject PrsFToSitScr;

    public Animator Anim;

    public bool Trigger;
    public bool OnDesk = false;

    private GameObject othher;

    private float Timer;
    public float TimeTo;

    public Transform PosToTeleport;

    public GameObject DiaryPref;
    public Transform WherePut;
    public GameObject UiPutDiary;
    public GameObject DeskTrig;
    public bool DairyPuted;


    public enum WhatsTrigger
    {
        Desk,
        Diary
    }
    public WhatsTrigger WhTrig = WhatsTrigger.Desk;

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            othher = other.gameObject;
            if (WhTrig == WhatsTrigger.Desk)  scrPrsF.SetActive(true);
            Trigger = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            if (WhTrig == WhatsTrigger.Desk) scrPrsF.SetActive(false);
            Trigger = false;
        }
    }

    private void Update()
    {
        
        if(Trigger == true)
        {
            if (WhTrig == WhatsTrigger.Desk)
            {
                if (Timer >= TimeTo)
                {
                    SceneManager.LoadScene(IndexNextLocation);
                }
                else if (OnDesk)
                {
                    Timer += Time.deltaTime;
                    Debug.Log(Timer);
                }
            }

            if (Input.GetKeyDown(KeyCode.F))
            {
                if(WhTrig == WhatsTrigger.Desk) Ceir(othher);

                else if (WhTrig == WhatsTrigger.Diary)  PuttingDiary();
            }
        }
    }

    public void PuttingDiary()
    {
        
            Instantiate(DiaryPref, WherePut.position, WherePut.rotation);
            DairyPuted = true;
            UiPutDiary.SetActive(false);
            DeskTrig.SetActive(true);
        
    }



    public void Ceir(GameObject Player)
    {
        Scrtrtrt.SetActive(false);
        PrsFToSitScr.SetActive(false);

        Player.GetComponent<FirstPersonController>().enabled = false;

        Player.GetComponent<CapsuleCollider>().enabled = false;
        Player.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
        Player.transform.position = PosToTeleport.position;
        Player.transform.rotation = PosToTeleport.rotation;

        Anim.GetComponent<Animator>().SetBool("Come", true);
        OnDesk = true;
    }
}
