using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision) //G�r s� att saker kan h�nda vid kollision
    {
        if (collision.gameObject.tag == "Pellet") //Om n�gon med EnemyDeath scriptet �r i kontakt med n�got med tagen "player"...
        {
            Destroy(gameObject); //Ta bort gameObjektet
        }
    }
}
