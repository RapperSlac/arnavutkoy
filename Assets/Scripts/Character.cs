using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{

    public float jumpForce = 5f; // Zýplama kuvveti
    private bool isGrounded = true; // Yerde mi kontrolü
    private bool canJumpInAir = false; // Havada iken zýplamaya izin verme kontrolü

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 0, 5) * Time.deltaTime);
        }


        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(2, 0, 0) * Time.deltaTime);
        }


        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-2, 0, 0) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, 0, -5) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W))
        {
             transform.Translate(new Vector3(0, 0, 40) * Time.deltaTime);
        }

        if (isGrounded)
        {
            canJumpInAir = true;
        }

        if (Input.GetKeyDown(KeyCode.Space) && (isGrounded || canJumpInAir))
        {
            Jump();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
        canJumpInAir = false;
    }

    private void OnCollisionExit(Collision collision)
    {
        isGrounded = false;
    }

    private void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        isGrounded = false;
        canJumpInAir = false;
    }
}




