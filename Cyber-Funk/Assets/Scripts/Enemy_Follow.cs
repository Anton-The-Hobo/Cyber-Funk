using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Follow : MonoBehaviour
{
    public GameObject player; //så fienden vet vad den ska följa efter
    public float speed; //variabel för hur snabbt fienden ska röra på sig

    private float distance; //variabel för distansen mellan spelaren och fienden
    
     void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);//ger tillbaka distansen mellan spelaren och fienden
        Vector2 direction = player.transform.position - transform.position;

        if (distance < 5) //om spelaren är mindre än 4 enheter ifrån fienden...
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
        }
    }
}
