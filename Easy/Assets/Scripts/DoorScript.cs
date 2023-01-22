using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorScript : MonoBehaviour
{
    public Animator anim;


    private void Start()
    {
        anim.GetComponent<Animator>();
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            if(Input.GetKeyDown(KeyCode.E))
            StartCoroutine(FadeIn());
        }
    }
    private IEnumerator FadeIn()
    {
        anim.GetComponent<Animator>().SetBool("FF", true);
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("School");
    }
}
