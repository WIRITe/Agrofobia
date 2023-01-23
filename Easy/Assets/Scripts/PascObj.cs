using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class PascObj : MonoBehaviour
{
    public int selfNumber;
    public string _str;

    public string NameOfSaveList;

    public void OnTriggerEnter(Collider other)
    {
        string o = SpawnerOfPascalcs.listOfPascalcs;
        string j = "1";

        StringBuilder sb = new StringBuilder(o);
        sb[selfNumber] = j[0];
        o = sb.ToString();

        PlayerPrefs.SetString(NameOfSaveList, o);

        Destroy(gameObject);
    }
}
