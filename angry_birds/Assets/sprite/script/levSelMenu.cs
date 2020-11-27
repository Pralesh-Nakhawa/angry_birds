using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levSelMenu : MonoBehaviour
{
   
    public void next()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void levMenu()
    {
        SceneManager.LoadScene(sceneBuildIndex: 1);
    }
    public void previous()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void restartL()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
