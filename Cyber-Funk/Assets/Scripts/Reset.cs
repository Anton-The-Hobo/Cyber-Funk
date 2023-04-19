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
    // Den metod som ska anv�ndas av knappen.
    {

        if (Input.GetKeyDown("r"))
        // Om man trycker p� r.
        {
            SceneManager.LoadScene("01_StartScene_safe");
            // S� startas scenen om.
        }
    }
}
