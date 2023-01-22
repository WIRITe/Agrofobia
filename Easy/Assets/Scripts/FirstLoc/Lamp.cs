using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour
{
    public AudioClip TakeMusic;
    public AudioSource audio;
    public GameObject lamp;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            audio.PlayOneShot(TakeMusic);
            GameObject obj = other.gameObject;
            GameObject H =  Instantiate(lamp, obj.transform.position + new Vector3(0.514f, 0.276f, 0.361f), lamp.transform.rotation);
            H.transform.SetParent(obj.transform);
            Destroy(gameObject);
            
        }
    }
}
