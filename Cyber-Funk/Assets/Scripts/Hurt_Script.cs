using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hurt_Script : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D enemy) //Gör så att saker kan hända vid kollision
    {
        if (enemy.gameObject.GetComponent<Movement_Script>().health <= 0) //om gameObject med taggen enemy health från scriptet movement är like med eller mindre än 0...
        {
            Destroy(enemy.gameObject); //förstö gameObjectet med taggen enemy
        }
        else //i andra fall...
        {
            enemy.gameObject.GetComponent<Movement_Script>().health--; //ta bort en health point
        }
    }
}
