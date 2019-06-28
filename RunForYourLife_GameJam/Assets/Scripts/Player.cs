using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10f;
    public float jumpforce = 8f;
    public float gravity = 30f;
    private Vector3 moveDir = Vector3.zero;
    public bool controlsEnabled = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CharacterController controller = gameObject.GetComponent<CharacterController>();
        if (controlsEnabled)
        {
            if (controller.isGrounded)
            {
                moveDir = new Vector3(1, 0, -Input.GetAxis("Horizontal"));

                moveDir = transform.TransformDirection(moveDir);

                moveDir *= speed;

                if (Input.GetButtonDown("Jump"))
                {
                    moveDir.y = jumpforce;
                }
            }
        }

        moveDir.y -= gravity * Time.deltaTime;
        controller.Move(moveDir * Time.deltaTime);

    }

}
