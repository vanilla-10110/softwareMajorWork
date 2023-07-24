using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;





public class startGame : MonoBehaviour
{


    public Collider headCollider;

    private void OnTriggerEnter(Collider collision)
    {
        
        if (collision.GetComponent<Collider>() == headCollider)
        {
            
            SceneManager.LoadScene("stage one");

        }
    }
   
}
