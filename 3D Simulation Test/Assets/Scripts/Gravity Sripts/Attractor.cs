using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attractor : MonoBehaviour
{
    public Rigidbody myRigidbody;

    

    private void FixedUpdate() 
    {
        Attractor[] attractors = FindObjectsOfType<Attractor>();    
        foreach(Attractor attractor in attractors)
        {
            if(attractor != this)
            {
                Attract(attractor);
            }
        }
    }

    private void Attract(Attractor objToAttract)
    {
        Rigidbody rbToAttract = objToAttract.myRigidbody;

        Vector3 directionToObj = myRigidbody.position - rbToAttract.position;
        float distance  = directionToObj.magnitude;

        float forceMagnitude = (myRigidbody.mass * rbToAttract.mass) / Mathf.Pow(distance, 2);
        Vector3 force = directionToObj.normalized * forceMagnitude;

        rbToAttract.AddForce(force);
    }
}
