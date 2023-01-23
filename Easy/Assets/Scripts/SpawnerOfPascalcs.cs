using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnerOfPascalcs : MonoBehaviour
{
    public Transform[] Positions;
    public GameObject[] ListOfPrafabsPascalcs;
    public static string listOfPascalcs;

    public string NameOfSeveList;

    public void Start()
    {
        if(PlayerPrefs.GetString(NameOfSeveList).Length > 0)
        {
            string _str = PlayerPrefs.GetString(NameOfSeveList);
            
            listOfPascalcs = _str;
        }
        else
        {
            for(int i = 0; i < Positions.Length; i++)
            {

                listOfPascalcs = listOfPascalcs + "0";
            }
        }
        
        for(int i = 0; i < listOfPascalcs.Length; i++)
        {
            string o = "0";
            if (listOfPascalcs[i] == o[0])
            {
                GameObject H = Instantiate(ListOfPrafabsPascalcs[i], Positions[i].position, Positions[i].rotation);
                H.GetComponent<PascObj>().selfNumber = i;
            }
        }
    }
}
