using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotificationSystem : MonoBehaviour
{
    [SerializeField] private GameObject[] myNotifications;
    [SerializeField] private int timeToLive;


    // Update is called once per frame
    void FixedUpdate()
    {
        if(timeToLive <= 0)
        {
            for(int i = 0; i < myNotifications.Length; i++)
            {
                myNotifications[i].SetActive(false);
            }
        }
        else
        {
            timeToLive -= 1;
        }
    }
}
