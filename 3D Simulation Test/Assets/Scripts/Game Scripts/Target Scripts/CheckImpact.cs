using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckImpact : MonoBehaviour
{
    [SerializeField] private GameObject soundManager;

    private void OnCollisionEnter(Collision other) 
    {
        if(other.collider.tag == "Player")
        {
            soundManager.GetComponent<PlayOnImpact>().PlayImpactSound();
        }    
    }
}
