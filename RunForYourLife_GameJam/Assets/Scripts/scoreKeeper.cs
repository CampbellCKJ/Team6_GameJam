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
    private List<int> bestTimeMS;
    private List<Stopwatch> bestTime;
    public  GameObject coinText;
    public int totalCoins;
    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.DeleteKey("totalCoins");
        totalCoins = PlayerPrefs.GetInt("totalCoins");
        timer = new Stopwatch();
        timer.Start();

    }

    // Update is called once per frame
    void Update()
    {

        timerText.text = "" + timer.ElapsedMilliseconds / 1000;
        //coinText = GameObject.FindGameObjectWithTag("coinText");
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
        timer.Start();
    }

    void runEnded()
    {
        timer.Stop();
        bestTime.Add(timer);
        var time = (int)timer.ElapsedMilliseconds;
        timer.Reset();
        bestTimeMS.Add(time);
        bestCoins.Add(coins);
        Mathf.Max(bestCoins.ToArray());
        
        coins = 0;
    }
}
