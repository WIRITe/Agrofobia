using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class TriggerScrimer : MonoBehaviour
{

    public bool Once;
    public bool IsItWas;

    public bool Sound;

    public AudioSource _audio;
    public AudioClip Musicc;

    public bool AnimScrim;

    public AnimationClip _anim;
    public Animator _animSt;

    public bool AnimPlaying;
    public float AnimTime;
    private float Timer;

    public void Update()
    {
        if(AnimPlaying)
        {
            if(Timer >= AnimTime) 
            {
                _animSt.SetBool("InTriggerEnter", false);
                AnimPlaying = false;
                Timer = 0;
            }
            else { Timer += Time.deltaTime; Debug.Log(Timer); }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            if(Once)
            {
                if(!IsItWas)
                {
                    if (Sound) _audio.PlayOneShot(Musicc);

                    if (AnimScrim)
                    {
                        _animSt.SetBool("InTriggerEnter", true);
                        AnimPlaying = true;
                    }
                    IsItWas = true;
                }
            }
            else
            {
                if (Sound) _audio.PlayOneShot(Musicc);

                if (AnimScrim)
                {
                    _animSt.SetBool("InTriggerEnter", true);
                    AnimPlaying = true;
                }
            }
            
        }
    }
}
