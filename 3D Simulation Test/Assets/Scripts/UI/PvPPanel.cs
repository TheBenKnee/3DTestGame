using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PvPPanel : MonoBehaviour
{
    [SerializeField] private Text title;
    [SerializeField] private Text score;
    [SerializeField] private Transform player1Transform;
    [SerializeField] private Transform player2Transform;
    [SerializeField] private PvpLife myLife;

    public int playerLost;

    private void OnEnable()
    {
        if(playerLost == 1)
        {
            title.text = "Player 2 Wins!";
        }
        if(playerLost == 2)
        {
            title.text = "Player 1 Wins!";
        }
        if(score)
        {
            score.text = "Time Lasted: " + myLife.grabTime() + " seconds";
        }
    }

    public void resetPosition()
    {
        Debug.Log("Resetting");
        player1Transform.position = new Vector3(-2, 2, -1);
        player2Transform.position = new Vector3(3, 2, -1);
        Time.timeScale = 1;
        gameObject.SetActive(false);
        myLife.startTime();
    }
}
