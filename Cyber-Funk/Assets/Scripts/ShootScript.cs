using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour //Script för var spelarens skott ska spawnas
{
    public Transform bulletUp; //Gör så att vi kan bestämma ett gameObject som ska spawnas
    public Transform bulletRight; //Gör så att vi kan bestämma ett gameObject som ska spawnas
    public Transform bulletDown; //Gör så att vi kan bestämma ett gameObject som ska spawnas
    public Transform bulletLeft; //Gör så att vi kan bestämma ett gameObject som ska spawnas


    // Update is called once per frame
    void Update()

    {
        if(Input.GetKeyDown(KeyCode.Space) && Input.GetKey(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Space) && Input.GetKey(KeyCode.W)) //Om mellanslag trycks ned...
        {
            Instantiate(bulletUp, transform.position, transform.rotation); //skapar det bestämda gameObjectet på samma plats
        }

        if (Input.GetKeyDown(KeyCode.Space) && Input.GetKey(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.Space) && Input.GetKey(KeyCode.D)) //Om mellanslag trycks ned...
        {
            Instantiate(bulletRight, transform.position, transform.rotation); //skapar det bestämda gameObjectet på samma plats
        }

        if (Input.GetKeyDown(KeyCode.Space) && Input.GetKey(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.Space) && Input.GetKey(KeyCode.S)) //Om mellanslag trycks ned...
        {
            Instantiate(bulletDown, transform.position, transform.rotation); //skapar det bestämda gameObjectet på samma plats
        }

        if (Input.GetKeyDown(KeyCode.Space) && Input.GetKey(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.Space) && Input.GetKey(KeyCode.A)) //Om mellanslag trycks ned...
        {
            Instantiate(bulletLeft, transform.position, transform.rotation); //skapar det bestämda gameObjectet på samma plats
        }
    }
}
                                                     