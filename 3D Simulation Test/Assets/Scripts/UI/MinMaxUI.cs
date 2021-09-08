using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MinMaxUI : MonoBehaviour
{
    private bool isMax = true;

    private void OnEnable() 
    {
        Screen.SetResolution(1600, 900, true);
    }

    public void changeFull()
    {
        isMax = !isMax;
        Screen.fullScreen = isMax;
    }

    public void changeResolution(int option)
    {
        switch(option)
        {
            case 0:
                Screen.SetResolution(1350, 1080, true);
                break;
            case 1:
                Screen.SetResolution(2700, 2160, true);
                break;
        }
        
    }
}
