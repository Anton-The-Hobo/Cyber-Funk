using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Script : MonoBehaviour

{
    private float horizontal; //Variabel för input på x-axeln
    private float vertical; //Variabel för input på y-axeln
    public float MoveSpeed = 8; //Variabel för hur mycket spelaren ska röra på sig
    

    private Vector2 Direction; //Positionen hos spelaren

    public Rigidbody2D rb; //Så att spelet vet vilken rigidbody2D den ska använda

    void Update()
    {
        ControllInputs(); //Gör så att metoden ControllInputs framkallas
    }

    void FixedUpdate()
    {
        Move(); //Gör så att metoden Move framkallas
    }

    void ControllInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal"); //Ger tillbaka ett värde på -1, 0 eller 1 beroende på om du tydker på a, ingenting eller d
        float moveY = Input.GetAxisRaw("Vertical"); //Ger tillbaka ett värde på -1, 0 eller 1 beroende på om du tydker på s, ingenting eller w

        Direction = new Vector2(moveX, moveY).normalized; //Normalized gör så att spelaren inte går snabbare när den går diagonalt
        //Direction har antingen värdet -1, 0 eller 1 på sina x- och y-värden 
    }

    void Move()
    {
        rb.velocity = new Vector2(Direction.x * MoveSpeed, Direction.y * MoveSpeed); //Flyttar spelaren i enheter per sekund
        //Inom vektorn så kommer MovesSpeed multipluceras med antingen directions värden (-1, 0 eller 1) vilket kommer ändra gameobjectets position på axlarna eller i andra ord flytta karaktären
    }
}
