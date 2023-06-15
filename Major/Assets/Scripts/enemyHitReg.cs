using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHitReg : MonoBehaviour
{
 
    public Rigidbody rb; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.name == "MyGameObjectName")
        {
            
            Debug.Log("Do something here");
        }

        if (collision.gameObject.tag == "Weapon")
        { 
            Debug.Log("we be dying");
        }
    }
    

}
