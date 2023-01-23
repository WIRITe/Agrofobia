using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject[] lattice;

    public static bool getedKey;

    public static GameObject KeyInHand;

    public AudioClip SoundOpenLattice;
    public AudioSource _audio;

    public GameObject KeyAll;
    public bool DoNeedToTurnOffKey;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            if (getedKey)
            {
                for(int i = 0; i < lattice.Length; i++) { lattice[i].SetActive(false); }
                _audio.PlayOneShot(SoundOpenLattice);
                Destroy(KeyInHand); 
                if(DoNeedToTurnOffKey) Destroy(KeyAll);
            }
        }
    }
}
