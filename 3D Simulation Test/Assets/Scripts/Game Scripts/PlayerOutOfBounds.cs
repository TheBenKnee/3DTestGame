using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerOutOfBounds : MonoBehaviour
{

    [SerializeField] private GameObject finishedPanel;

    // Called when another trigger enters the current trigger
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Time.timeScale = 0.25f;
            finishedPanel.SetActive(true);
        }
    }
}
