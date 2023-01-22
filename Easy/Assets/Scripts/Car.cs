using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Car : MonoBehaviour
{
    public Animator Anim;
    public AudioClip Vju;
    public AudioSource ss;

    public bool first = true;


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && first)
        {
            ss.PlayOneShot(Vju);
            Anim.GetComponent<Animator>().SetBool("Run", true);
            first = false;
        }
    }
}
