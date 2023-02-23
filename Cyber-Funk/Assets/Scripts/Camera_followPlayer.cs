using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_followPlayer : MonoBehaviour
{
    public Transform target; //Så att spelet vet vilken position kameran ska följa
    public Vector3 cameraPosition;
    public float followingSpeed; //Hur snabbt kameran ska röra på sig för att hinna ikapp spelaren

    void FixedUpdate()
    {
        transform.position = target.position + cameraPosition; //Kamerans position kommer vara spelarens position
    }

}
