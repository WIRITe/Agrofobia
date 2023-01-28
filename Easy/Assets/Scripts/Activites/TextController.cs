using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextController : MonoBehaviour
{
    public TMP_Text _text;
    public string rightCode;

    public bool hasMusic;
    public AudioClip _Clip;
    public AudioSource _audio;

    public GameObject DoorForUnlock;

    public void Update()
    {
        if(_text.text == rightCode)
        {
            OnRightAnswerEnter();
        }

        if(_text.text.Length >= 5)
        {
            _text.text = "";
        }

    }

    public void OnRightAnswerEnter()
    {
        if (hasMusic)
        {
            _audio.PlayOneShot(_Clip);
        }
        DoorForUnlock.GetComponent<GoToNextLocation>().IsDoorBlocked = false;
    }
}
