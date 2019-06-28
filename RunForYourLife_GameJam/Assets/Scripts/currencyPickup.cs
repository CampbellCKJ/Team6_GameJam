using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class currencyPickup : MonoBehaviour
{
    public scoreKeeper ScoreKeeper;
    public GameObject prefabSFX;
    //public GameObject Text;
    public GameObject coinUI;
    private void Start()
    {
        //coinUI = GameObject.FindGameObjectWithTag("coinUI");
    }

    private void Update()
    {
        this.gameObject.transform.RotateAround(this.gameObject.transform.position, Vector3.up, 45 * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.GetComponent<AudioSource>().Play(0);
            ScoreKeeper = other.gameObject.GetComponent<scoreKeeper>();
            ScoreKeeper.addCoins();
            Instantiate(prefabSFX, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.identity);
            coinUI.GetComponent<Animator>().Play("uiSpin", -1, 0f);
            Destroy(this.gameObject);
        }
    }
}
