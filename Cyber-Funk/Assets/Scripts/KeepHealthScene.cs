using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class KeepHealthScene : MonoBehaviour
{
    void start()
    {
        DontDestroyOnLoad(this);
    }
}
