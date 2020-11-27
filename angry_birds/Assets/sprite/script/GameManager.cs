using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    
    public GameObject levcomp;
    public void EndGame() {
        Debug.Log("gover");
        Restart();
    }
    public void GameWin()
    {
        Debug.Log("win");
      levcomp.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);   
    }
}
