using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatBoss : MonoBehaviour
{
    public float health;
    public GameObject go;


    private void OnTriggerEnter2D(Collider2D collision) //G�r s� att saker kan h�nda vid kollision
    {
        if (collision.gameObject.tag == "Pellet") //Om n�gon med EnemyDeath scriptet �r i kontakt med n�got med tagen "pellet"...
        {
            health--;
        }

        if (collision.gameObject.tag == "Pellet" && health <= 0) //Om n�gon med EnemyDeath scriptet �r i kontakt med n�got med tagen "pellet"...
        {
            GameObject newObject = Instantiate(go, new Vector2(10.77f, 8.8f), Quaternion.identity);
            Destroy(gameObject);
        }
    }


}
