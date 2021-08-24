using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Note: This should be attached to the source of the music.
public class MuteMusic : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        //Set to 'm' currently
        if(Input.GetButtonDown("Mute"))
        {
            //Grabs the attached audio source
            AudioSource myAudio = gameObject.GetComponent<AudioSource>();

            //Will mute and unmute the audio of the attached audio source
            myAudio.mute = !myAudio.mute;
        }
    }
}
