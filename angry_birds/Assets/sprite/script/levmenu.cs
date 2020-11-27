using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class levmenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void lev1B()
    {
        SceneManager.LoadScene(sceneBuildIndex:2);   
    }

    public void lev2B()
    {
        SceneManager.LoadScene(sceneBuildIndex: 3);
    }
    public void lev3B()
    {
        SceneManager.LoadScene(sceneBuildIndex: 4);
    }
    public void mainmenu()
    {
        SceneManager.LoadScene(sceneBuildIndex: 0);
    }
}
