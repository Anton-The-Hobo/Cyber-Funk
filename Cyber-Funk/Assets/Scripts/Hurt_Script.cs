using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hurt_Script : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D Player) //G�r s� att saker kan h�nda vid kollision
    {
        if (Player.gameObject.GetComponent<PlayerHealth>().playerHealth <= 1) //om gameObject med taggen enemy health fr�n scriptet movement �r like med eller mindre �n 0...
        {
            Destroy(Player.gameObject); //f�rst� gameObjectet med taggen enemy
        }
        else //i andra fall...
        {
            Player.gameObject.GetComponent<PlayerHealth>().playerHealth--; //ta bort en health point
        }
    }
}
