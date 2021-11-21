using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    public Text leftScoreText;
    public Text rightScoreText;
    public Text gameOverText;

    public EventSystemManager eventSystem;

    public GameManager gameManager;

    void Start()
    {
        eventSystem.OnRightGoalEnter.AddListener(UpdateLeftScore);
        eventSystem.OnLeftGoalEnter.AddListener(UpdateRightScore);
        eventSystem.OnPlayerWin.AddListener(PlayerWin);
        eventSystem.OnPlayerLose.AddListener(PlayerLose);
    }

    public void UpdateRightScore()
    {
        rightScoreText.text = gameManager.rightPoint.ToString();
    }

    public void UpdateLeftScore()
    {
        leftScoreText.text = gameManager.leftPoint.ToString();
    }

    public void PlayerWin()
    {
        gameOverText.text = "You Win";
    }

    public void PlayerLose()
    {
        gameOverText.text = "You Lose";
    }
}
