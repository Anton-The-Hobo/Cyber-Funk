using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Script : MonoBehaviour

{
    private float horizontal; //Variabel f�r input p� x-axeln
    private float vertical; //Variabel f�r input p� y-axeln
    public float MoveSpeed = 8; //Variabel f�r hur mycket spelaren ska r�ra p� sig
    

    private Vector2 Direction; //Positionen hos spelaren

    public Rigidbody2D rb; //S� att spelet vet vilken rigidbody2D den ska anv�nda

    void Update()
    {
        ControllInputs(); //G�r s� att metoden ControllInputs framkallas
    }

    void FixedUpdate()
    {
        Move(); //G�r s� att metoden Move framkallas
    }

    void ControllInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal"); //Ger tillbaka ett v�rde p� -1, 0 eller 1 beroende p� om du tydker p� a, ingenting eller d
        float moveY = Input.GetAxisRaw("Vertical"); //Ger tillbaka ett v�rde p� -1, 0 eller 1 beroende p� om du tydker p� s, ingenting eller w

        Direction = new Vector2(moveX, moveY).normalized; //Normalized g�r s� att spelaren inte g�r snabbare n�r den g�r diagonalt
        //Direction har antingen v�rdet -1, 0 eller 1 p� sina x- och y-v�rden 
    }

    void Move()
    {
        rb.velocity = new Vector2(Direction.x * MoveSpeed, Direction.y * MoveSpeed); //Flyttar spelaren i enheter per sekund
        //Inom vektorn s� kommer MovesSpeed multipluceras med antingen directions v�rden (-1, 0 eller 1) vilket kommer �ndra gameobjectets position p� axlarna eller i andra ord flytta karakt�ren
    }
}
