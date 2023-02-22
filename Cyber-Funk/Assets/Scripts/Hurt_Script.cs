using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hurt_Script : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision) //Gör så att saker kan hända vid kollision
    {
        if (collision.gameObject.GetComponent<Movement_Script>().health <= 0) //om gameObject med taggen collisions health från scriptet movement är like med eller mindre än 0...
        {
            Destroy(collision.gameObject); //förstö gameObjectet med taggen collision
        }
        else //i andra fall...
        {
            collision.gameObject.GetComponent<Movement_Script>().health--; //ta bort en health point
        }
    }
}
