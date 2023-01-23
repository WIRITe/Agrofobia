using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingText : MonoBehaviour
{
    public GameObject Player;

    // Update is called once per frame
    public void Update()
    {
        transform.LookAt(Player.transform.position);    
    }
}
