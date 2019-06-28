﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class menuButtons : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject ingameMenu;
    public GameObject statsMenu;
    public GameObject gameOverMenu;
    public scoreKeeper ScoreKeeper;
    
    public Player player;
    public GameObject enemy;
    // Start is called before the first frame update

    private void Start()
    {
        //ScoreKeeper = GameObject.FindWithTag("Player").GetComponent<scoreKeeper>();
        //player = GameObject.FindWithTag("Player").GetComponent<Player>();
        enemy.SetActive(false);
    }
    public void startButton()
    {
        ingameMenu.SetActive(true);

        mainMenu.SetActive(false);
        ScoreKeeper.startTimer();
        player.controlsEnabled = true;
        enemy.SetActive(true);
    }
    public void quitButton()
    {
        Application.Quit();
    }
    public void statsButton()
    {
        statsMenu.SetActive(true);

        mainMenu.SetActive(false);
        ScoreKeeper.updateStats();
    }
    public void backtoMain()
    {
        mainMenu.SetActive(true);
        statsMenu.SetActive(false);
        ingameMenu.SetActive(false);
    }

    public void gameOver()
    {
        mainMenu.SetActive(false);
        player.controlsEnabled = false;
        ingameMenu.SetActive(false);
        gameOverMenu.SetActive(true);
        ScoreKeeper.runEnded();
        mainMenu.SetActive(false);
        mainMenu.SetActive(false);

    }

    public void restartGame()
    {
        SceneManager.LoadScene("Programmer_Test_Scene");
    }
}
