using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GUI_health_Loss : MonoBehaviour
{
    public GameObject go;
    public GameObject healthImage;

    public Material goodHealth;
    public Material midHealth;
    public Material badHealth;


    void Update()
    {
        HealthChange();
    }

    void HealthChange()
    {
        if(go.GetComponent<PlayerHealth>().playerHealth >= 3)
        {
            healthImage.GetComponent<Renderer>().material = goodHealth;
        }

        if (go.GetComponent<PlayerHealth>().playerHealth == 2)
        {
            healthImage.GetComponent<Renderer>().material = midHealth;
        }

        if (go.GetComponent<PlayerHealth>().playerHealth <= 1)
        {
            healthImage.GetComponent<Renderer>().material = badHealth;
        }
    }
}
