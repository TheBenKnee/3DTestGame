using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetManager : MonoBehaviour
{
    [SerializeField] private GameObject[] targets;
    public int maxScore = 0;

    public void checkCollision(int incomingValue)
    {
        if(incomingValue > maxScore)
        {
            maxScore = incomingValue;
        }
    }
}
