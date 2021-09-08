using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameInput : MonoBehaviour
{
    public static bool isOk = true;

    public void enterName()
    {

        //isOk = true;

        string myInput = this.gameObject.GetComponent<InputField>().text;

        for(int i = 0; i < myInput.Length; i++)
        {
            if(char.IsDigit(myInput[i]))
            {
                isOk = false;
                break;
            }
            if(i >= 10)
            {
                isOk = false;
                break;
            }
        }

        if(isOk)
        {
            Debug.Log("Name accepted");
        }
        else
        {
            Debug.Log("Name denied");
        }
    }
}
