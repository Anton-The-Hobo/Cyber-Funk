using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinTheGame : MonoBehaviour
{

    public GameObject go;

    void Update()
    {
        Win();
    }

    void Win()
    {
        if (go.GetComponent<EnemyDeath>().health <= 1)
        {
            SceneManager.LoadScene("WinScreen");
        }
    }
}
