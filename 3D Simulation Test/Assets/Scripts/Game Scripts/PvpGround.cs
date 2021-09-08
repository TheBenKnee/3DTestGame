using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PvpGround : MonoBehaviour
{
    [SerializeField] public PvPPanel finishedPanel;

    // Called when another trigger enters the current trigger
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered");
        if(other.tag == "Player" && !finishedPanel.gameObject.activeSelf)
        {
            endGame(other);
            // Time.timeScale = 0.25f;
            // if(other.gameObject.name == "Player 1")
            // {
            //     finishedPanel.playerLost = 1;
            // }
            // else
            // {
            //     finishedPanel.playerLost = 2;
            // }
            // finishedPanel.gameObject.SetActive(true);
        }
    }

    public void endGame(Collider other)
    {
        Debug.Log("Ending game");
        Time.timeScale = 0.25f;
        if(finishedPanel)
        {
            if(other.gameObject.name == "Player 1")
            {
                finishedPanel.playerLost = 1;
            }
            else
            {
                finishedPanel.playerLost = 2;
            }
            finishedPanel.gameObject.SetActive(true);
        }
    }
}
