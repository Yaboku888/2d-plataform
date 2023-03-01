using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Movimiento")]
    public float MoveSpeed;

    [Header("Salto")]
    public float jumpsote;

    [Header("Componentes")]
    public Rigidbody2D TheRB;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TheRB.velocity = new Vector2(MoveSpeed * Input.GetAxis("Horizontal"), TheRB.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            TheRB.velocity = new Vector2(TheRB.velocity.x, jumpsote);
        }
    }
}
