using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform target;
    public Transform myTransform;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        target.position = new Vector3(target.position.x, transform.position.y, target.position.z);
        transform.LookAt(target);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        speed = speed + 0.0001f;
    }


}
