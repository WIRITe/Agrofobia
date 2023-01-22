using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiaryTriggerToDesk : MonoBehaviour
{
    public GameObject DeskTrigg;
    public GameObject Diary;
    public GameObject diarytrigg;
    public GameObject OutDiarry;

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            OutDiarry.SetActive(true);
            if (Input.GetKeyDown(KeyCode.F))
            {
                OutDiarry.SetActive(false);
                diarytrigg.SetActive(false);
                DeskTrigg.SetActive(true);
                Diary.SetActive(true);
            }
        }
        
        
    }
}
