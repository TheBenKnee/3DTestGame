using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnImpact : MonoBehaviour
{   
    [SerializeField] private AudioSource myAudio;

    [SerializeField] private AudioClip impactSound;

    public void PlayImpactSound()
    {
        myAudio.PlayOneShot(impactSound);
    }
}
