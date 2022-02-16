using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacmanMovement : MonoBehaviour
{

    Rigidbody rb;
    [SerializeField] float movementSpeed = 6f;
    [SerializeField] float jumpForce = 5f;
    Transform trans;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        trans = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");


        rb.velocity = new Vector3(horizontalInput * movementSpeed, rb.velocity.y, verticalInput * movementSpeed);



        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }

        Debug.Log(transform.rotation.eulerAngles.y);

        
        if (Input.GetKeyDown("w") && transform.rotation.eulerAngles.y >= 89 && transform.rotation.eulerAngles.y <= 91) 
        {
            transform.Rotate(0, -90, 0);
        } 
        if (Input.GetKeyDown("w") && transform.rotation.eulerAngles.y >= 269 && transform.rotation.eulerAngles.y <= 271)
        {
            transform.Rotate(0, 90, 0);
        }

        if (Input.GetKeyDown("a") && transform.rotation.eulerAngles.y >= -1 && transform.rotation.eulerAngles.y <= 1)
        {
            transform.Rotate(0, -90, 0);
        }
        if (Input.GetKeyDown("a") && transform.rotation.eulerAngles.y >= 179 && transform.rotation.eulerAngles.y <= 181)
        {
            transform.Rotate(0, 90, 0);
        }
        if (Input.GetKeyDown("d") && transform.rotation.eulerAngles.y >= -1 && transform.rotation.eulerAngles.y <= 1)
        {
            transform.Rotate(0, 90, 0);
        }
        if (Input.GetKeyDown("d") && transform.rotation.eulerAngles.y >= 179 && transform.rotation.eulerAngles.y <= 181)
        {
            transform.Rotate(0, -90, 0);
        }
        if (Input.GetKeyDown("s") && transform.rotation.eulerAngles.y >= 269 && transform.rotation.eulerAngles.y <= 271)
        {
            transform.Rotate(0, -90, 0);
        }
        if (Input.GetKeyDown("s") && transform.rotation.eulerAngles.y >= 89 && transform.rotation.eulerAngles.y <= 91)
        {
            transform.Rotate(0, 90, 0);
        }


    }

    void Jump()
    {
        rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
      
    }




}
