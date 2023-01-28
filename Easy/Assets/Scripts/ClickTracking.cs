using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ClickTracking : MonoBehaviour
{
    public GameObject[] ObgOffOnRightEnter;

    public GameObject lattice;

    public AudioClip MusicOnRightAns;
    public AudioClip MusicOnNotRightAns;

    public int howMathRightButtons;

    public AudioSource _audio;

    public Camera _camera;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            Ray _ray = _camera.ScreenPointToRay(new Vector3(Screen.width/2, Screen.height/2, 0));

            RaycastHit hit;

            if (Physics.Raycast(_ray, out hit))
            {
                if (hit.collider.gameObject.GetComponent<ButtonConyrol>()) 
                {
                    howMathRightButtons -= hit.collider.gameObject.GetComponent<ButtonConyrol>().IsItPressed(); 
                }
                    
            }
            
        }

        if(howMathRightButtons <= 0)
        {
            WhenAllRight();
        }
    }

    public void WhenAllRight()
    {
        for(int i = 0; i < ObgOffOnRightEnter.Length; i++)
        {
            ObgOffOnRightEnter[i].SetActive(true);
        }

        lattice.SetActive(false);
    }
}
