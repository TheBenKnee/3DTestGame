using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Vector3 baseVector = new Vector3(0.2f, 0, 0.2f);
    private Vector3 addingVector;

    public static Vector3 North = new Vector3(0, 0, 0);

    // Update is called once per frame
    void FixedUpdate()
    {
        CheckInput();
    }

    public void TestMove()
    {
        GetComponent<Rigidbody>().velocity += new Vector3(0, 2, 0);
    }

    private void CheckInput()
    {
        addingVector = new Vector3(0, 0, 0);
        if(Input.GetAxis("Vertical") < 0)
        {
            addingVector.z -= baseVector.z;
        }
        if(Input.GetAxis("Vertical") > 0)
        {
            addingVector.z += baseVector.z;
        }
        if(Input.GetAxis("Horizontal") < 0)
        {
            addingVector.x -= baseVector.z;
        }
        if(Input.GetAxis("Horizontal") > 0)
        {
            addingVector.x += baseVector.z;
        }
        GetComponent<Rigidbody>().velocity += addingVector;
    }
}
