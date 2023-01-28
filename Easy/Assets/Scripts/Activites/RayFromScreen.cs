using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RayFromScreen : MonoBehaviour
{
    public Camera _camera;

    public TMP_Text _textOnScreen;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray _ray = _camera.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));

            RaycastHit hit;

            if (Physics.Raycast(_ray, out hit))
            {
                if (hit.collider.gameObject.GetComponent<Button>() != null)
                {
                    string str = _textOnScreen.text;
                    str += hit.collider.gameObject.GetComponent<Button>().ReturnSelfNumber();
                    _textOnScreen.text = str;
                }
            }
        }
    }
}
