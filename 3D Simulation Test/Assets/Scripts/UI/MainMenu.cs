using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private int test;

    public void Quit()
    {
        Application.Quit();
    }

    public void SceneButton(string sceneToLoad)
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    
}
