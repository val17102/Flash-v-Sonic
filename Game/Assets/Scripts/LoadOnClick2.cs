using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadOnClick2: MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(sceneName:"Map 2");
    }
}