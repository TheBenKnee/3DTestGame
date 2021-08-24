using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{

    [SerializeField] private GameObject pausePanel;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Reset") && !pausePanel.activeSelf)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
