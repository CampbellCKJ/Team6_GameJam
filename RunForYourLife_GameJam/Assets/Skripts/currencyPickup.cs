using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class currencyPickup : MonoBehaviour
{
    public scoreKeeper ScoreKeeper;
    // Start is called before the first frame update

    private void Update()
    {
        this.gameObject.transform.RotateAround(this.gameObject.transform.position, Vector3.up, 360 * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ScoreKeeper = other.gameObject.GetComponent<scoreKeeper>();
            ScoreKeeper.addCoins();
            Destroy(this.gameObject);
        }
    }
}
