using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class menuButtons : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject ingameMenu;
    public GameObject statsMenu;
    public scoreKeeper ScoreKeeper;
    public Player player;
    // Start is called before the first frame update

    private void Start()
    {
        ScoreKeeper = GameObject.FindWithTag("Player").GetComponent<scoreKeeper>();
        player = GameObject.FindWithTag("Player").GetComponent<Player>();

    }
    public void startButton()
    {
        ingameMenu.SetActive(true);

        mainMenu.SetActive(false);
        ScoreKeeper.startTimer();
        //player.toggleControlsEnabled();
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
}
