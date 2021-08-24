using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishedPanel : MonoBehaviour
{
    [SerializeField] private GameObject scoreKeeper;
    [SerializeField] private Text title;
    [SerializeField] private Text score;
    [SerializeField] private Transform playerTransform;


    private void OnEnable()
    {
        switch(scoreKeeper.GetComponent<TargetManager>().maxScore)
        {
            case 0:
                title.text = "Nice Try!";
                break;
            case 1:
                title.text = "Success!";
                break;
            case 2:
                title.text = "Amazing!";
                break;
            case 3:
                title.text = "Out of this world!";
                break;
            default:
                title.text = "Interesting score.";
                break;
        }
        score.text = scoreKeeper.GetComponent<TargetManager>().maxScore.ToString();
    }

    public void resetPosition()
    {
        playerTransform.position = new Vector3(0, 2, -1);
        Time.timeScale = 1;
        gameObject.SetActive(false);
        scoreKeeper.GetComponent<TargetManager>().maxScore = 0;
    }
}
