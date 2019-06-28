using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using UnityEngine.UI;

public class scoreKeeper : MonoBehaviour
{
    public int coins;
    public int score;
    public Stopwatch timerQ;
    public Text timerText;
    private List<int> bestCoins;
    private List<int> bestTimeMS;
    private List<Stopwatch> bestTime;
    public  GameObject coinText;
    public int totalCoins;
    public Text highestCoin;
    public Text highestTime;
    public Text totalCoinage;
    public int time;
    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.DeleteKey("totalCoins");
        totalCoins = PlayerPrefs.GetInt("totalCoins");
        timerQ = new Stopwatch();
        bestCoins = new List<int>();
        bestTimeMS = new List<int>();
        bestCoins.Add(PlayerPrefs.GetInt("highestCoinage"));
        bestTimeMS.Add(PlayerPrefs.GetInt("highestTimed"));
            

    }

    // Update is called once per frame
    void Update()
    {
        //highestCoin = GameObject.FindGameObjectWithTag("highestCoin").GetComponent<Text>();
       // highestTime = GameObject.FindGameObjectWithTag("highestTime").GetComponent<Text>();


        timerText.text = "" + timerQ.ElapsedMilliseconds / 1000;
        //coinText = GameObject.FindGameObjectWithTag("coinText");

        if (Input.GetKeyDown(KeyCode.F10))
        {
            startTimer();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            runEnded();
        }

    }

    public void addCoins()
    {
        coins++;
        PlayerPrefs.SetInt("totalCoins", totalCoins + 1);
        totalCoins = PlayerPrefs.GetInt("totalCoins");
        UnityEngine.Debug.Log(totalCoins);
        coinText.GetComponent<TMPro.TextMeshProUGUI>().text = "" + coins;

    }

    public void startTimer()
    {
        timerQ.Start();
        coins = 0;
    }

    public void runEnded()
    {
        timerQ.Stop();
        time = (int)timerQ.ElapsedMilliseconds / 1000;
        timerQ.Reset();
        bestTimeMS.Add(time);
        bestCoins.Add(coins);
        Mathf.Max(bestCoins.ToArray());
        highestCoin.text = "Best Coins: " + Mathf.Max(bestCoins.ToArray());
        highestTime.text = "Best Time: " + Mathf.Max(bestTimeMS.ToArray());
        PlayerPrefs.SetInt("highestCoinage", Mathf.Max(bestCoins.ToArray()));
        PlayerPrefs.SetInt("highestTimed", Mathf.Max(bestTimeMS.ToArray()));
        coins = 0;
    }

    public void updateStats()
    {
        highestCoin.text = "Best Coins: " + Mathf.Max(bestCoins.ToArray());
        highestTime.text = "Best Time: " + Mathf.Max(bestTimeMS.ToArray());
        totalCoinage.text = "Total Coins: " + PlayerPrefs.GetInt("totalCoins");
        

    }

    public void wipeStats()
    {
        bestTimeMS.Clear();
        bestCoins.Clear();
    }
}
