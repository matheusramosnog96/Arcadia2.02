using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1Movimento : MonoBehaviour
{
    public Rigidbody rb;
    private float horizontalInput;
    private float depthInput;
    [SerializeField] private float jumpForce = 10.0f;
    [SerializeField] private bool isGround;
    
    void    Start () {
        rb = GetComponent<Rigidbody>();
        isGround = false;
    }

    void    Update () {
        horizontalInput = Input.GetAxis("Horizontal");
        depthInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * 10 * depthInput);
        transform.Translate(Vector3.right * Time.deltaTime * 10 * horizontalInput);


        if (Input.GetKeyDown(KeyCode.Space) && isGround)
        {
            rb.AddForce((new Vector3(0, 0.9f, 0) * jumpForce), ForceMode.Impulse);
            isGround = false;
            Debug.Log("PULA");
        }



 
    
    
    }
    private void OnCollisionEnter(Collision collision)
    {
        isGround = true;
        Debug.Log("Colidiu!");
    }
}