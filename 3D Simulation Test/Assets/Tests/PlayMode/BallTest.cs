using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;


public class BallTest
{
    bool sceneLoaded;
    bool referencesSetup;
    GameObject test;

    public void ButtonClicked(NameInput nameIn)
    {
        nameIn.enterName();
    }

    [OneTimeSetUp]
    public void OneTimeSetup()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
        SceneManager.LoadScene("Unit Testing", LoadSceneMode.Single);
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        sceneLoaded = true;
    }

    void SetupReferences()
    {
        if (referencesSetup)
        {
            return;
        }

        test = GameObject.Find("TestObject");       
        // Transform[] objects = Resources.FindObjectsOfTypeAll<Transform>();
        // foreach (Transform t in objects)
        // {
        //     if (t.name == "Name of Gameobject")
        //     {
        //         someComponentReference = t.GetComponent<SomeComponent>();
        //     }
        // }
        
        referencesSetup = true;
    }
    
    [UnityTest]
    public IEnumerator TestReferencesNotNullAfterLoad()
    {
        yield return new WaitWhile(() => sceneLoaded == false);
        SetupReferences();
        Assert.AreEqual(expected:new Vector3(2, 32, 2), actual:test.GetComponent<Transform>().position);
        //Add all other references as well for quick nullref testing
        yield return null;
    }





















    // [SetUp]
    // public void Setup()
    // {
    //     SceneManager.LoadScene("Unit Testing");
    // }

    [Test]
    public void SceneTesting()
    {
        Assert.IsTrue(GameObject.Find("Main Camera").activeSelf);
    }

    [UnityTest]
    public IEnumerator IntiUnitTest()
    {
        GameObject nameInput = new GameObject();

        InputField inField = nameInput.AddComponent<InputField>();
        inField.text = "1testing";
        NameInput nameIn = nameInput.AddComponent<NameInput>();



        GameObject enterButton = new GameObject();

        Button button = enterButton.AddComponent<Button>();
        button.onClick.AddListener(delegate () {
            this.ButtonClicked(nameIn);
        });
        button.onClick.Invoke();



        Assert.AreEqual(expected:false, actual:NameInput.isOk);

        yield return null;
    }

    // [UnityTest]
    // public IEnumerator TestPausing()
    // {
    //     GameObject testObject = new GameObject();
    //     GameObject pausePanelObject = new GameObject();
    //     PanelManager panelManager = testObject.AddComponent<PanelManager>();
    //     pausePanelObject.SetActive(false);
    //     panelManager.PausePanel = pausePanelObject;

    //     panelManager.pauseTrigger(); 

    //     Assert.AreEqual(expected:0f, actual:Time.timeScale);

    //     yield return null;
    // }

    // [UnityTest]
    // public IEnumerator TestUnpausing()
    // {
    //     GameObject testObject = new GameObject();
    //     GameObject pausePanelObject = new GameObject();
    //     PanelManager panelManager = testObject.AddComponent<PanelManager>();
    //     panelManager.PausePanel = pausePanelObject;

    //     panelManager.pauseTrigger();

    //     Assert.AreEqual(expected:1f, actual:Time.timeScale);

    //     yield return null;
    // }

    // [UnityTest]
    // public IEnumerator TestPauseUnpause()
    // {
    //     GameObject testObject = new GameObject();
    //     GameObject pausePanelObject = new GameObject();
    //     PanelManager panelManager = testObject.AddComponent<PanelManager>();
    //     pausePanelObject.SetActive(false);
    //     panelManager.PausePanel = pausePanelObject;

    //     panelManager.pauseTrigger();
    //     panelManager.pauseTrigger();

    //     Assert.AreEqual(expected:1f, actual:Time.timeScale);

    //     yield return null;
    // }

    // [UnityTest]
    // public IEnumerator CheckEndGameTimeSlow()
    // {
    //     GameObject testObject = GameObject.Instantiate(new GameObject());
    //     testObject.tag = "Player";

    //     testObject.AddComponent<PlayerMovement>();
    //     testObject.AddComponent<Rigidbody>();
    //     SphereCollider mySpehere = testObject.AddComponent<SphereCollider>();

    //     mySpehere.isTrigger = true;
        

    //     GameObject secondObject = GameObject.Instantiate(new GameObject());
    //     PvpGround myGround = secondObject.AddComponent<PvpGround>();
    //     BoxCollider myBox = secondObject.AddComponent<BoxCollider>();

    //     myBox.isTrigger = true;
    //     myGround.endGame(mySpehere);

    //     Assert.AreEqual(expected:0.25f, actual:Time.timeScale);

    //     yield return null;
    // }
}
