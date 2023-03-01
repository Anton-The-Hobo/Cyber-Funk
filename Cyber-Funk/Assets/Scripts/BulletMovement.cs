using UnityEngine;

public class BulletMovement : MonoBehaviour //Script för spelarskottens riktning och hur länge de ska vara
{
    void OnCollisionEnter2D(Collision2D collision) //Detta är metod som gör att vissa saker kan hända när colliders kolliderar (bara för 2d fysik)
    {
        if (collision.gameObject.tag == "Enemy") //Om något med detta script är i kontakt med något med tagen "Enemy"...
        {
            Destroy(gameObject); //förstör gameObjektet
        }
    }

    // Start: Anropas en gång i starten av spelet
    void Start() 
    {
        // Förstör projektilen 1 sekund efter att den skapas. Detta görs för att undvika att scenen blir för full av projektiler.
        Destroy(gameObject, 1);
    }

    // Update: Anropas en gång per frame
    void Update()
    {
        // Förflyttar projektilen konstant uppåt (position av projektilen uppdateras), värdet 0.1f bestämmer hur snabbt objektet kommer röra sig
        transform.position = new Vector3(transform.position.x, transform.position.y + 0.1f, transform.position.z);
    }
}
