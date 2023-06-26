using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;





public class startGame : MonoBehaviour
{


    public Collider headCollider;

    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("Hello");
        if (collision.GetComponent<Collider>() == headCollider)
        {
            Debug.Log("why no work?");
            SceneManager.LoadScene("stage one");

        }
    }
   
}
