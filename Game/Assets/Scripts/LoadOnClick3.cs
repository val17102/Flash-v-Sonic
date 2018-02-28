using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadOnClick3: MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(sceneName: "Map 3");
    }
}