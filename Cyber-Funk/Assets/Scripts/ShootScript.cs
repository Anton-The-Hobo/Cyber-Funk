using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour //Script f�r var spelarens skott ska spawnas
{
    public Transform bulletUp; //G�r s� att vi kan best�mma ett gameObject som ska spawnas
    public Transform bulletRight; //G�r s� att vi kan best�mma ett gameObject som ska spawnas
    public Transform bulletDown; //G�r s� att vi kan best�mma ett gameObject som ska spawnas
    public Transform bulletLeft; //G�r s� att vi kan best�mma ett gameObject som ska spawnas


    // Update is called once per frame
    void Update()

    {
        if(Input.GetKeyDown(KeyCode.Space) && Input.GetKey(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Space) && Input.GetKey(KeyCode.W)) //Om mellanslag trycks ned...
        {
            Instantiate(bulletUp, transform.position, transform.rotation); //skapar det best�mda gameObjectet p� samma plats
        }

        if (Input.GetKeyDown(KeyCode.Space) && Input.GetKey(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.Space) && Input.GetKey(KeyCode.D)) //Om mellanslag trycks ned...
        {
            Instantiate(bulletRight, transform.position, transform.rotation); //skapar det best�mda gameObjectet p� samma plats
        }

        if (Input.GetKeyDown(KeyCode.Space) && Input.GetKey(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.Space) && Input.GetKey(KeyCode.S)) //Om mellanslag trycks ned...
        {
            Instantiate(bulletDown, transform.position, transform.rotation); //skapar det best�mda gameObjectet p� samma plats
        }

        if (Input.GetKeyDown(KeyCode.Space) && Input.GetKey(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.Space) && Input.GetKey(KeyCode.A)) //Om mellanslag trycks ned...
        {
            Instantiate(bulletLeft, transform.position, transform.rotation); //skapar det best�mda gameObjectet p� samma plats
        }
    }
}
                                                     