using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float rotSpeed = 2.0f;
    public float gravity = 0f;
    public float curGravity;

    public Transform spawnPoint;

    private Animator animator;
    protected CharacterController _char;

    public int hp;
    public int spd;
    public int jumpspd;

    // Start is called before the first frame update
    void Start()
    {
        curGravity = gravity;
        animator = GetComponent<Animator>();
        _char = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Rotation();
    }

    public void Movement()
    {
        //sets the vertical and horizontal based of the player input
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        //sets the animations float based of the vertical and horizontal
        animator.SetFloat("_x", horizontal, 0.1f, Time.deltaTime);
        animator.SetFloat("_y", vertical, 0.1f, Time.deltaTime);
        Vector3 moveDirection = new Vector3(horizontal, curGravity, vertical);

        //sets a move direction based of a vector 3
        if (_char.isGrounded)
        {
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= spd;
            if (Input.GetButton("Jump"))
            {
                animator.SetBool("isgrounded", true);
                moveDirection.y = jumpspd;
            }
            else
            {
                animator.SetBool("isgrounded", false);
            }
        }
        //Moves the character to the direction
        _char.Move(moveDirection * Time.deltaTime);

    }

    public void OnTriggerEnter(Collider other)
    {
        //Respawns the player and resets the position to the spawnPoint
        if (other.gameObject.name == "Respawn")
        {
            this.gameObject.transform.position = spawnPoint.position;

        }
    }

    public void CheckCollison()
    {
        //Checks if there is collision if there is set the gravity
        if (_char.isGrounded)
        {
            curGravity = gravity;
        }
    }

    public void Rotation()
    {
        //sets the rotation based of player input
        float rotate = Input.GetAxis("Rotate");
        transform.Rotate(0.0f, rotate * rotSpeed, 0.0f);
    }

    public void HurtPlayer(int damage)
    {
        //Hurst the player
        hp -= damage;
        //If the players hp is below 0 reset them back at the spawn location
        if (hp <= 0)
        {
            this.gameObject.transform.position = spawnPoint.position;
            
        }
    }

    public void SlowPlayer(int slow)
    {
        //slows the player down
        spd -= slow;
    }

    public void NormalSpeed()
    {
        //returns the player back to normal speed
        spd = spd + 1;
    }

    public void StunPlayer()
    {
        //stuns the player
        spd -= spd;
    }
}
