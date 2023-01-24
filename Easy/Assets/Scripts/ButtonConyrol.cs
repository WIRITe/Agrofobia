using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonConyrol : MonoBehaviour
{
    public bool pressed = false;

    public bool RightButton;

    public int IsItPressed()
    {
        if(!pressed) 
        { 
            if(RightButton)
            {
                pressed = true;
                return 1;
            }
        }

        return 0;
    }
}
