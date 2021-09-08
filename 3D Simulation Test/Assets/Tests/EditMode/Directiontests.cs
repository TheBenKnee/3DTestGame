using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class Directiontests
{
    // // A Test behaves as an ordinary method
    // [Test]
    // public void Movement()
    // {
    //     // Use the Assert class to test conditions
    //     Assert.AreEqual(expected:new Vector3(x:0, y:0, z:0), actual:PlayerMovement.North);
    // }


    [Test]
    public void UnitTest()
    {
        /***
            The bool determining accepting or declining the name should be true 
            by default and only changed to false if the name is not accepted.
        ***/
        Assert.AreEqual(expected:true, actual:NameInput.isOk);
    }

}
