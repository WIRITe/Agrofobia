using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ClickTracking : MonoBehaviour
{
    public AudioClip MusicOnRightAns;
    public AudioClip MusicOnNotRightAns;

    public GameObject[] ButtonsWithRightAnswers;
    public GameObject[] ButtonsWithNoRightAnswers;

    public AudioSource _audio;

    public Camera _camera;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            GameObject Switch;

            if (Input.GetKeyDown(KeyCode.E))
            {
                if (Physics.Raycast(transform.position, transform.forward, out hit))
                {
                    if (ButtonsWithRightAnswers.Contains(hit.collider.gameObject))
                    {

                    }
                }
            }
        }
    }
    }
