using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiggerEvents : MonoBehaviour
{
  public int score;
  public float bounceForce = 10f;
  private Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
           rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy5"))
        {
          transform.position = new Vector3(-3.39f, -0.94f, -27.41f);
        }
        if (other.gameObject.CompareTag("Enemy6"))
        {
          
            rb.AddForce(Vector3.up * bounceForce, ForceMode.Impulse);
      
        }
        
         if (other.gameObject.CompareTag("Player"))
       {
         GetComponent<MeshRenderer>().material.color = new Color(1f,0f,0f);
       }  

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy7"))
        {
            score= score-1;
            Debug.Log(score);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log( "In Air"); 
    }

}
