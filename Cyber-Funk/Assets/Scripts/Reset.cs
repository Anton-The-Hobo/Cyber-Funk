using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    void Update()
    {
        GameReset();
        // Anropar metoden.
    }
    public void GameReset()
    // Den metod som ska användas av knappen.
    {

        if (Input.GetKeyDown("r"))
        // Om man trycker på r.
        {
            SceneManager.LoadScene("01_StartScene_safe");
            // Så startas scenen om.
        }
    }
}
