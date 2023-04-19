using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    public GameObject go;

    void Update()
    {
        GameOver();
    }

    void GameOver()
    {
        if (go.GetComponent<PlayerHealth>().playerHealth <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
