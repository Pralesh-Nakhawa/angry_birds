using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdred : MonoBehaviour
{
    public Rigidbody2D rb;
    public SpringJoint2D sj;
    public GameObject hook;
    public Rigidbody2D bow;
    public float size = 2.5f;
    public bool isPressed;
    public bool birdDie = false;
    
   
    private void Update()
    {
        if (isPressed){
            Vector2 mousePosi =Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (Vector3.Distance(bow.position, mousePosi) > size)
            {
                //  Debug.Log(Vector2.Distance(mousePosi,rb.position ));
                // Debug.Log(rb.position);
                //Debug.Log(hook.position);
                // Debug.Log(rb.position-hook.position);
                // Debug.Log(Vector2.Distance (bow.position,mousePosi));
                rb.position= (bow.position+(mousePosi- bow.position).normalized * size );
                //Debug.Log((mousePosi - bow.position));
            }

            else{ rb.position = mousePosi;}
            
        }
       
    }
   private void OnMouseDown()
       {
           isPressed = true;
           rb.isKinematic = true;
    
       }
       private void OnMouseUp()
       {
           isPressed = false;
           rb.isKinematic = false;
        
           StartCoroutine(Release());
        

    }
       IEnumerator Release(){
           yield return new WaitForSeconds(0.15f);
           GetComponent<SpringJoint2D>().enabled = false;
           this.enabled=false;
        yield return new WaitForSeconds(4f);
        { Destroy(hook);
            birdDie = true;
            if (FindObjectOfType<Pig>().die == false && birdDie == true)
            {
                FindObjectOfType<GameManager>().EndGame();
            }
            

        }

    }
   
}
