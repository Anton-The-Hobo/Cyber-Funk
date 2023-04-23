using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public int sceneBuildIndex;
    public Animator transition;

    public float transitionTime = 1f; // Hur snabbt animationen ska spelas


   
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        print("Trigger Entered");
        
        if(other.tag == "Player") //om ett object with the tag "player" colliderar med "levelswitch" so byter den scene.
        {
            LoadNextLevel();
        }
    }

    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + sceneBuildIndex));

    }



    IEnumerator LoadLevel(int levelIndex)
    {
        //play animation

        transition.SetTrigger("Start");

        //wait

        yield return new WaitForSeconds(transitionTime);

        //load scene

        SceneManager.LoadScene(levelIndex);
    }

}
