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
<<<<<<< HEAD

        if (controller.isGrounded)
        {
            moveDir = new Vector3(Input.GetAxis("Vertical"), 0, -Input.GetAxis("Horizontal"));

            moveDir = transform.TransformDirection(moveDir);

            moveDir *= speed;

            if (Input.GetButtonDown("Jump"))
            {
                moveDir.y = jumpforce;
=======
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
>>>>>>> b26f77756ee13932264f5084a9367f2a27f79fc9
            }
        }

        moveDir.y -= gravity * Time.deltaTime;
        controller.Move(moveDir * Time.deltaTime);

    }

}
