using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPushed : MonoBehaviour
{
    public float pushPower = 2.0f;

    public Rigidbody body;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacles")
        {
            body = other.gameObject.GetComponent<Rigidbody>();
            body.constraints = RigidbodyConstraints.None;
            Vector3 points = new Vector3(Random.Range(1, 3), Random.Range(1, 3), Random.Range(1, 3));
            Vector3 dir = points - transform.position;

            dir = -dir.normalized;

            body.AddForce(dir * pushPower);


        }
    }

}
