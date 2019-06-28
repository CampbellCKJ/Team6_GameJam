using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wipeStats : MonoBehaviour
{
    public scoreKeeper ScoreKeeper;
    // Start is called before the first frame update
    public void wipeStatistics()
    {
        PlayerPrefs.DeleteKey("totalCoins");
        PlayerPrefs.DeleteKey("highestCoinage");
        PlayerPrefs.DeleteKey("highestTimed");
        ScoreKeeper.wipeStats();
    }
}
