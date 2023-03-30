using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hurt_Script : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D enemy) //G�r s� att saker kan h�nda vid kollision
    {
        if (enemy.gameObject.GetComponent<PlayerHealth>().playerHealth <= 0) //om gameObject med taggen enemy health fr�n scriptet movement �r like med eller mindre �n 0...
        {
            Destroy(enemy.gameObject); //f�rst� gameObjectet med taggen enemy
        }
        else //i andra fall...
        {
            enemy.gameObject.GetComponent<PlayerHealth>().playerHealth--; //ta bort en health point
        }
    }
}
