using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_Enemy2 : MonoBehaviour
{
    //Prefabs
    public GameObject prefab;

    //Intervaller
    public float interval;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawn(interval, prefab));
    }

    private IEnumerator spawn(float Interval, GameObject GO)
    {
        yield return new WaitForSeconds(Interval);
        GameObject newObject = Instantiate(GO, new Vector2(-6.071978f, 0.775661f), Quaternion.identity);
        StartCoroutine(spawn(Interval, GO));
    }
}
