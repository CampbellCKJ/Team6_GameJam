using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
public class scoreKeeper : MonoBehaviour
{

    public int coins;
    public int score;
    public Stopwatch timer;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addCoins()
    {
        coins++;
    }

    public void startTimer()
    {
        timer = new Stopwatch();
        timer.Start();
    }
}
