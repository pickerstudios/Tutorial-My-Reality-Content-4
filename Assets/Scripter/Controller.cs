using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    public void Map()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Map");


    }
    public void Scene01()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Scene01");

    }
    public void Scene02()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Scene02");

    }
    public void Scene03()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Scene03");


    }
    public void Quit()
    {
        Application.Quit();
    }
    
}
