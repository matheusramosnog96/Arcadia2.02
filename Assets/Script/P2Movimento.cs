using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2Movimento : MonoBehaviour
{
    public float Hp;
    public Rigidbody2D rbp2;
    public float velocidadeMovimento = 25.0f;

    public float moveX;
    public float moveY;


    // Start is called before the first frame update
    void Start()
    {
        rbp2 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveX = Input.GetAxisRaw("Horizontal2");
        moveY = Input.GetAxisRaw("Vertical2");

        rbp2.velocity = new Vector2(moveX * velocidadeMovimento, moveY * velocidadeMovimento);

        

    }
}
