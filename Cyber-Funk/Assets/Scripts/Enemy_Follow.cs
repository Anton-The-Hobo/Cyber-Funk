using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Follow : MonoBehaviour
{
    public GameObject player; //s� fienden vet vad den ska f�lja efter
    public float speed; //variabel f�r hur snabbt fienden ska r�ra p� sig

    private float distance; //variabel f�r distansen mellan spelaren och fienden
    
     void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);//ger tillbaka distansen mellan spelaren och fienden
        Vector2 direction = player.transform.position - transform.position;

        if (distance < 5) //om spelaren �r mindre �n 4 enheter ifr�n fienden...
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
        }
    }
}
