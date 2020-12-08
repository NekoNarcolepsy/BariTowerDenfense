using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToTitle : MonoBehaviour
{
    public string sceneName;
    public void Title()
    {
        SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
    }

}
