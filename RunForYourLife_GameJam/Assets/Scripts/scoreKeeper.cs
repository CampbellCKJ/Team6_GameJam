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
    }

    public void addCoins()
    {
        coins++;
    }

    public void startTimer()
    {
        timer.Start();
    }
}
