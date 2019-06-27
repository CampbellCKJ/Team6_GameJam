using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using UnityEngine.UI;
public class scoreKeeper : MonoBehaviour
{
    public int coins;
    public int score;
    public Stopwatch timer;
    public Text timerText;
    private List<int> bestCoins;
    private List<Stopwatch> bestTime;
    public GameObject coinText;
    //public TMPro.Textr

    // Start is called before the first frame update
    void Start()
    {
        timer = new Stopwatch();

        timer.Start();

    }

    // Update is called once per frame
    void Update()
    {
        timerText.text = "" + timer.Elapsed;
        coinText.GetComponent<TMPro.TextMeshPro>().text = "" + coins;
    }

    public void addCoins()
    {
        coins++;

    }

    public void startTimer()
    {
        timer.Start();
    }

    void runEnded()
    {
        timer.Stop();
        bestTime.Add(timer);
        
        timer.Reset();
        bestCoins.Add(coins);
        Mathf.Max(bestCoins.ToArray());
        
        //add coins to total coins here TO BE DONE WHEN TOTAL COINS ADDED
        coins = 0;
    }
}
