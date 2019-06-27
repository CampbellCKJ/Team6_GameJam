using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class currencyPickup : MonoBehaviour
{
    public scoreKeeper ScoreKeeper;
    public GameObject prefabSFX;
    public GameObject Text;
    private void Update()
    {
        this.gameObject.transform.RotateAround(this.gameObject.transform.position, Vector3.up, 360 * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.GetComponent<AudioSource>().Play(0);
            ScoreKeeper = other.gameObject.GetComponent<scoreKeeper>();
            ScoreKeeper.addCoins();
            Instantiate(prefabSFX, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
