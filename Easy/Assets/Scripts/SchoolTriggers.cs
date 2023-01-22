using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchoolTriggers : MonoBehaviour
{
    public GameObject Trigger;
    public GameObject NewTrigger;
    public GameObject Task;
    public GameObject TaskNew;
    public GameObject DialogueS;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Knock");
        if (other.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            
                Debug.Log("Collider");
                Trigger.SetActive(false);
                NewTrigger.SetActive(true);
                Task.SetActive(false);
                TaskNew.SetActive(true);
                
            
        }
    }
    private void Start()
    {
        NewTrigger.SetActive(false);
    }
    private IEnumerator Dialogue()
    {
        Debug.Log("Coroutine");
        DialogueS.SetActive(true);
        yield return new WaitForSeconds(4);
        DialogueS.SetActive(false);
    }
}
