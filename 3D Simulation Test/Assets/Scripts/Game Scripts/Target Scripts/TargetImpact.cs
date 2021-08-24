using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetImpact : MonoBehaviour
{
    [SerializeField] private int score;
    [SerializeField] private GameObject manager;

    // Called when another trigger enters the current trigger
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            manager.GetComponent<TargetManager>().checkCollision(score);
        }
    }
}
