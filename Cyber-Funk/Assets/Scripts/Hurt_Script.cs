using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hurt_Script : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision) //G�r s� att saker kan h�nda vid kollision
    {
        if (collision.gameObject.GetComponent<Movement_Script>().health <= 0) //om gameObject med taggen collisions health fr�n scriptet movement �r like med eller mindre �n 0...
        {
            Destroy(collision.gameObject); //f�rst� gameObjectet med taggen collision
        }
        else //i andra fall...
        {
            collision.gameObject.GetComponent<Movement_Script>().health--; //ta bort en health point
        }
    }
}
