using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Dungeon : MonoBehaviour
{
    public static bool DungeonStarted = false;
    public GameObject Teacher;
    public GameObject Player;
    public Transform Pos;

    public Animator Anim;


    public float TimerTo;
    private float Timer;
    private bool time_end = false;

    public void Start()
    {
        Player.GetComponent<FirstPersonController>().enabled = false;

        if(Anim != null) Anim.SetBool("Finish", false);
    }

    public void Update()
    {
    
        if (Timer >= TimerTo)
        {
            if (Anim != null) Anim.SetBool("Finish", true);

            if (Teacher != null) Teacher.SetActive(false);

            UnCeir();
        }
        else { Timer += Time.deltaTime; }
        
    }

    public void UnCeir()
    {
        Player.GetComponent<FirstPersonController>().enabled = true;

        Player.GetComponent<CapsuleCollider>().enabled = true;
        Player.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        Player.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
        Player.transform.position = Pos.position;
        Player.transform.rotation = Pos.rotation;
    }
}
