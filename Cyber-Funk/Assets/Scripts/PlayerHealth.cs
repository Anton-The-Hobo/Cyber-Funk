using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public int maxHealth = 3; //how many health points our player has
    public int playerHealth;

    private void Awake()
    {
        playerHealth = maxHealth;
        DontDestroyOnLoad(this.gameObject);
    }

}
