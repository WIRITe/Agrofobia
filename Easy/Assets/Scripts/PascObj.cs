using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class PascObj : MonoBehaviour
{
    public int selfNumber;

    public string NameOfSaveList;

    public static string j = "1";

    public void OnTriggerEnter(Collider other)
    {
        string o = PlayerPrefs.GetString(NameOfSaveList);

        StringBuilder _sb = new StringBuilder(o);

        _sb[selfNumber] = j[0];

        o = _sb.ToString();

        SpawnerOfPascalcs.listOfPascalcs = o;

        Destroy(gameObject);
    }
}
