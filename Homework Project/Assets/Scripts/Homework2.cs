using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homework2 : MonoBehaviour
{ 
    public float originalSpeed;
    public float sprintSpeed= 10f;  
    bool is_W_pressed;  
    bool is_A_pressed;
    bool is_S_pressed; 
    bool is_D_pressed; 
    bool is_sprint_pressed;
   
    // or is it public float moveSpeed; 

    // Start is called before the first frame update
    void Start()
    { 
        
    }

    // Update is called once per frame
    void Update()
    {
      is_W_pressed= Input.GetKey(KeyCode.W);
      is_A_pressed= Input.GetKey(KeyCode.A);
      is_S_pressed= Input.GetKey(KeyCode.S);
      is_D_pressed= Input.GetKey(KeyCode.D);
     
     is_sprint_pressed= Input.GetKeyDown(KeyCode.LeftShift);
      
      if (is_sprint_pressed)
      {
        transform.position= transform.position+ new Vector3(0,0,1) * (originalSpeed+sprintSpeed)* Time.deltaTime;
      }
      if(is_W_pressed)
        { 
             transform.position= transform.position+ new Vector3(0,0,1)* originalSpeed* Time.deltaTime; 
        }
      
      if (is_sprint_pressed && is_W_pressed)
      {
        transform.position= transform.position* originalSpeed*sprintSpeed* Time.deltaTime;
        }

    
      
      if(is_A_pressed)
        { 
             transform.position= transform.position+ new Vector3(-1,0,0)* originalSpeed* Time.deltaTime; 
        }
      
      if(is_S_pressed)
        { 
             transform.position= transform.position+ new Vector3(0,0,-1)* originalSpeed* Time.deltaTime; 
        }
      
      if(is_D_pressed)
        { 
             transform.position= transform.position+ new Vector3(1,0,0)* originalSpeed* Time.deltaTime; 
        }
     
     bool JumpPressed = Input.GetKeyDown(KeyCode.Space);
     if (JumpPressed)
     {
         Rigidbody MyRigidbody =GetComponent<Rigidbody>();
         MyRigidbody.AddForce( new Vector3 (0,5,0), ForceMode.Impulse);
     }
        
      
       //Vector3 forwardVectorExample = new Vector3 (0, 0, 1);
      //  movementDirection = movementDirection + Vector3.forward;
        //movementDirection = movementDirection + Vector3.right; 
       // movementDirection = movementDirection.normalized;
       // I don't understand what all that means^ 
    }
}
