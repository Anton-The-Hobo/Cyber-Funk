using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour //Script f�r var spelarens skott ska spawnas
{
    public Transform bullet; //G�r s� att vi kan best�mma ett gameObject som ska spawnas
    
    // Update is called once per frame
    void Update()

    {
        if(Input.GetKeyDown(KeyCode.Space)) //Om mellanslag trycks ned...
        {
            Instantiate(bullet, transform.position, transform.rotation); //skapar det best�mda gameObjectet p� samma plats
        }
    }
}
                                                     