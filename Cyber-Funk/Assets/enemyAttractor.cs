using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAttractor : MonoBehaviour
{
   
    public float speed;    // how fast the enemy is chasing you



    void OnTriggerEnter2D(Collider2D Player) //G�r s� att saker kan h�nda vid kollision
    {
        Vector2 direction = Player.gameObject.transform.position - transform.position;

        transform.position = Vector2.MoveTowards(this.transform.position, Player.gameObject.transform.position, speed * Time.deltaTime);
    }
}
