using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pig : MonoBehaviour
{
    public GameObject pig;
    public GameObject pattern;
    public Text scoreT;
    public float score = 2000f;
    public bool die=false;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "ground"||collision.relativeVelocity.magnitude > 4f){
           Destroy(pig);
            die = true;
            scoreT.text = score.ToString();
            if (die == true)
            {
                FindObjectOfType<GameManager>().GameWin();
            }

            Instantiate(pattern,transform.position,Quaternion.identity);
        }
        
    }
    
}
