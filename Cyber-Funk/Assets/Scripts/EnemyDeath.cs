using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    public float health;


    private void OnTriggerEnter2D(Collider2D collision) //Gör så att saker kan hända vid kollision
    {
        if (collision.gameObject.tag == "Pellet") //Om någon med EnemyDeath scriptet är i kontakt med något med tagen "pellet"...
        {
            health--;
        }

        if (collision.gameObject.tag == "Pellet" && health <= 0) //Om någon med EnemyDeath scriptet är i kontakt med något med tagen "pellet"...
        {
            Destroy(gameObject);
        }
    }

   
}
