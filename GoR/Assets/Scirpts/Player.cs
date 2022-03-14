using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Set in Inspector")]
    public float posLeftX = -3.5F;
    public float posRightX = 3.7f;
    public float jumpGravity = 1500F;

    Rigidbody rg;
    bool canJump = true;
    // Start is called before the first frame update
    void Start()
    {
        rg = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Rotate
        transform.Rotate(Vector3.right * Time.deltaTime * 10);

        // Move right and Move left
        if (Input.GetKeyDown(KeyCode.A))
        {
            moveLeft();
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            moveRight();
        }

        // jump
        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            rg.velocity = new Vector3(rg.velocity.x, jumpGravity * Time.deltaTime, rg.velocity.z);
            canJump = false;
        }
    }

    void moveLeft()
    {
        if (transform.position.x > 0)
        {
            transform.position = new Vector3(0, transform.position.y, transform.position.z);
        }
        else if(transform.position.x == 0)
        {
            transform.position = new Vector3(posLeftX, transform.position.y, transform.position.z);
        }
    }

    void moveRight()
    {
        if (transform.position.x < 0)
        {
            transform.position = new Vector3(0, transform.position.y, transform.position.z);
        }
        else if (transform.position.x == 0)
        {
            transform.position = new Vector3(posRightX, transform.position.y, transform.position.z);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Land")
        {
            canJump = true;
        }
    }
}
