using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public void Scene1()
    {
        SceneManager.LoadScene("Scene1 1");
    }

    public void Scene2()
    {
        SceneManager.LoadScene("Scene1 2");
    }

    public void Scene3()
    {
        SceneManager.LoadScene("Scene1 3");
    }
}

