using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_followPlayer : MonoBehaviour
{
    public Transform target; //S� att spelet vet vilken position kameran ska f�lja
    public Vector3 cameraPosition;
    public float followingSpeed; //Hur snabbt kameran ska r�ra p� sig f�r att hinna ikapp spelaren

    void FixedUpdate()
    {
        transform.position = target.position + cameraPosition; //Kamerans position kommer vara spelarens position
    }

}
