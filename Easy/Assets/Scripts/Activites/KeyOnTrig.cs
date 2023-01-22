using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyOnTrig : MonoBehaviour
{
    public GameObject _key;
    public GameObject KeyPref;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            
            GameObject obj = other.gameObject;

            GameObject H = Instantiate(KeyPref, obj.transform.position + new Vector3(0.514f, 0.276f, 0.361f), KeyPref.transform.rotation);
            H.transform.SetParent(obj.transform);
            Key.KeyInHand = H;

            Key.getedKey = true;
            
            Destroy(_key);

        }
    }
}
