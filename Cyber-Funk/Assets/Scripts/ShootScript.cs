using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour //Script för var spelarens skott ska spawnas
{
    public Transform bullet; //Gör så att vi kan bestämma ett gameObject som ska spawnas
    
    // Update is called once per frame
    void Update()

    {
        if(Input.GetKeyDown(KeyCode.Space)) //Om mellanslag trycks ned...
        {
            Instantiate(bullet, transform.position, transform.rotation); //skapar det bestämda gameObjectet på samma plats
        }
    }
}
                                                     