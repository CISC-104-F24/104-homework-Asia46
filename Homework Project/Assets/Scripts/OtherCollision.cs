using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  private void OnCollisionEnter(Collision collision)
    {
         if (collision.gameObject.CompareTag("Player"))
       {
         GetComponent<MeshRenderer>().material.color = new Color(1f,0f,0f);
       }  
        
    }
  
  private void OnCollisionStay(Collision collision)
    {
        
    }

  private void OnCollisionExit(Collision collision)
    {
        
    }
    

    
}