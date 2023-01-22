using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Txt : MonoBehaviour
{
    public TextMeshPro mytext;
    public GameObject myobject;

    // Update is called once per frame
    void Update()
    {
        mytext.transform.parent = myobject.transform;
    }
}
