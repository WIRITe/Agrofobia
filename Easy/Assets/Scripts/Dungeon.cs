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
    private bool time_end = true;

    public void Start()
    {
        Player.GetComponent<FirstPersonController>().enabled = false;

        if(Anim != null) Anim.SetBool("Finish", false);
    }

    public void Update()
    {
    
        if (Timer >= TimerTo && time_end)
        {
            if (Anim != null) Anim.SetBool("Finish", true);

            if (Teacher != null) Teacher.SetActive(false);

            UnCeir();
            time_end = false;
        }
        else { Timer += Time.deltaTime; }
        Debug.Log(Timer);
    }

    public void UnCeir()
    {
        Player.transform.position = Pos.position;

        Debug.Log("gfvs");
        Player.GetComponent<FirstPersonController>().enabled = true;

        Player.GetComponent<CapsuleCollider>().enabled = true;
        Player.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        Player.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;

        
    }
}
