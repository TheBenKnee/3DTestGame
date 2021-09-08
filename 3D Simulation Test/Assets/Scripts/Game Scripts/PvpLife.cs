using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PvpLife : MonoBehaviour
{
    private float lifeTime;

    // Start is called before the first frame update
    void OnEnable()
    {
        lifeTime = Time.time;
    }

    public float grabTime()
    {
        return(Time.time - lifeTime);
    }

    public void startTime()
    {
        lifeTime = Time.time;
    }

    public void doTree()
    {
        Debug.Log("Nameing");
    }

}
