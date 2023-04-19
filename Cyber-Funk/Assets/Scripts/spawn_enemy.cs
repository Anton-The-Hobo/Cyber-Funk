using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_enemy : MonoBehaviour
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
        GameObject newObject = Instantiate(GO, new Vector2(11.43f, 0.68f), Quaternion.identity);
        StartCoroutine(spawn(Interval, GO));
    }
}
