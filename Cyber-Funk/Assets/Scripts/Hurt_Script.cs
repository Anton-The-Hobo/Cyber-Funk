using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hurt_Script : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D Player) //Gör så att saker kan hända vid kollision
    {
        if (Player.gameObject.GetComponent<PlayerHealth>().playerHealth <= 1) //om gameObject med taggen enemy health från scriptet movement är like med eller mindre än 0...
        {
            SceneManager.LoadScene("GameOver");
            Destroy(Player.gameObject); //förstö gameObjectet med taggen enemy
        }
        else //i andra fall...
        {
            Player.gameObject.GetComponent<PlayerHealth>().playerHealth--; //ta bort en health point
        }
    }
}
