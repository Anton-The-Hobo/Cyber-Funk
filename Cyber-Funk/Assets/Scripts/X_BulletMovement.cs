using UnityEngine;
using UnityEngine.InputSystem;

public class X_BulletMovement : MonoBehaviour //Script f�r spelarskottens riktning och hur l�nge de ska vara
{
    public float speed;

    // Start: Anropas en g�ng i starten av spelet
    void Start() 
    {
        // F�rst�r projektilen 1 sekund efter att den skapas. Detta g�rs f�r att undvika att scenen blir f�r full av projektiler.
        Destroy(gameObject, 1);
    }

    // Update: Anropas en g�ng per frame
    void FixedUpdate()
    {
        Shoot();
    }

    void Shoot()
    {
        // F�rflyttar projektilen konstant upp�t (position av projektilen uppdateras), v�rdet 0.1f best�mmer hur snabbt objektet kommer r�ra sig
        transform.position = new Vector3(transform.position.x + speed, transform.position.y, transform.position.z);
    }

    void OnCollisionEnter2D(Collision2D collision) //Detta �r metod som g�r att vissa saker kan h�nda n�r colliders kolliderar (bara f�r 2d fysik)
    {
        if (collision.gameObject.tag == "Enemy") //Om n�got med detta script �r i kontakt med n�got med tagen "Enemy"...
        {
            Destroy(gameObject); //f�rst�r gameObjektet
        }
    }
}
