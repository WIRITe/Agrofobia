using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerNeed : MonoBehaviour
{
    public GameObject Player;
    public Transform Pos;
    public GameObject Canv;

    public static bool Act;

    public void Update()
    {
        if (Act)
        {
            Canv.SetActive(true);

            if (Input.GetKeyDown(KeyCode.F)) 
            {
                Player.transform.position = Pos.position;

                Player.GetComponent<FirstPersonController>().enabled = true;

                Player.GetComponent<CapsuleCollider>().enabled = true;
                Player.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
                Player.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;

                Act = false;
            }
        }
    }
}
