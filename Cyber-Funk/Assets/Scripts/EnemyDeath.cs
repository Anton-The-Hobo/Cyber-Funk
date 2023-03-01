using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision) //Gör så att saker kan hända vid kollision
    {
        if (collision.gameObject.tag == "Pellet") //Om någon med EnemyDeath scriptet är i kontakt med något med tagen "player"...
        {
            Destroy(gameObject); //Ta bort gameObjektet
        }
    }
}
