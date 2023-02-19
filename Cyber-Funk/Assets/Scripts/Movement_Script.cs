using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Script : MonoBehaviour
{
    private float horizontal; //Variabel f�r input p� x-axeln
    private float vertical; //Variabel f�r input p� y-axeln
    public float MoveSpeed = 8; //Variabel f�r hur mycket spelaren ska r�ra p� sig

    private Vector2 Direction;

    public Rigidbody2D rb; //S� att spelet vet vilken rigidbody2D den ska anv�nda

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
