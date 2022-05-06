using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_management : MonoBehaviour
{
    public void Scene1()
    {
        SceneManager.LoadScene("collecting");
    }
    public void Scene2()
    {
        SceneManager.LoadScene("fighting");
    }
    public void quit()
    {
        Application.Quit();

    }
    public void home()
    {
        SceneManager.LoadScene("home screen");
    }
}


