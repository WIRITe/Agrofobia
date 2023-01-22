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


    public AnimationClip _anim;
    public Animator Anim;


    public float TimerTo;
    private float Timer;
    private bool time_end = false;

    public void Start()
    {
        Player.GetComponent<FirstPersonController>().enabled = false;
        Anim.Play(_anim.name);
    }

    public void Update()
    {
    
        if (Timer >= TimerTo && !time_end)
        {
            Teacher.SetActive(false);
            UnCeir();

            time_end = true;
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
