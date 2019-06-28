using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPosition : MonoBehaviour {
    public Transform Player;
    public float offsetx;
    public float offsety;
    public float offsetz;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Player.position + new Vector3(offsetx, offsety, offsetz);
        //transform.Translate(new Vector3(offset, 0, 0));
    }
}
