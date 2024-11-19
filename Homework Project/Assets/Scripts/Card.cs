using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Card : MonoBehaviour
{
    public int health; 
    public int power; 
    public string name; 
    public TextMeshProUGUI rightShield; 
    public TextMeshProUGUI LeftAttack; 
    public Vector3 Tapped= new Vector3(0,0,-90); 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        health=health-damage;
        rightShield.text=health.ToString();
    }

    public void AddCounter(int counter)
    { 
        power=power-counter; 
        LeftAttack.text=power.ToString(); 
      
       if (power>5)
       { 
        LeftAttack.color= new Color(0,1,1,1);
       }
       
    }
     
    public void IsTapped(bool turned )
    {
        if (turned)
        { 
           transform.eulerAngles=Tapped;
        }
    }

}
