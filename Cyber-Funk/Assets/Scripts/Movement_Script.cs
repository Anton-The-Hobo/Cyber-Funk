using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Script : MonoBehaviour
{
    private float horizontal; //Variabel för input på x-axeln
    private float vertical; //Variabel för input på y-axeln
    public float MoveSpeed = 8; //Variabel för hur mycket spelaren ska röra på sig

    private Vector2 Direction;

    public Rigidbody2D rb; //Så att spelet vet vilken rigidbody2D den ska använda

    void Update()
    {
        ControllInputs();
    }

    void FixedUpdate()
    {
        Move();    
    }

    void ControllInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        Direction = new Vector2(moveX, moveY).normalized;
    }

    void Move()
    {
        rb.velocity = new Vector2(Direction.x * MoveSpeed, Direction.y * MoveSpeed);
    }
}
