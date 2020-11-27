using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    // Start is called before the first frame update
   public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    // Update is called once per frame
   public void Quit()
    {
        Application.Quit();
    }
    public void mainmenu()
    {
        SceneManager.LoadScene(sceneBuildIndex:0);
    }
    public void levmenu()
    {
        SceneManager.LoadScene(sceneBuildIndex: 1);
    }
}
