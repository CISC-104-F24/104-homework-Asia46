using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCollison : MonoBehaviour
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
      private void OnCollisionEnter(Collision collision)
    {
       if (collision.gameObject.CompareTag("Enemy2"))
        {
          transform.position = new Vector3(-3.39f, -0.94f, -27.41f);
        }
        if (collision.gameObject.CompareTag("Enemy3"))
        {
          
            rb.AddForce(Vector3.up * bounceForce, ForceMode.Impulse);
      
        }

    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            score= score-1;
            Debug.Log(score);
        }
        

    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log( "In Air"); 
    }
    

}
