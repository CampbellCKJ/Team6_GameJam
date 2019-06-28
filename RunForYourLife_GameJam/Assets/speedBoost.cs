using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedBoost : MonoBehaviour
{
    public Player player;
    public GameObject plane1;
    public GameObject plane2;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            player = other.gameObject.GetComponent<Player>();
            player.speed = player.speed + 2.5f;
            Invoke("normalize", 5);
            plane1.GetComponent<MeshRenderer>().enabled = false;
            plane2.GetComponent<MeshRenderer>().enabled = false;
        }
    }


    private void normalize()
    {
        player.speed = 10;
        Destroy(this.gameObject);
    }
}
