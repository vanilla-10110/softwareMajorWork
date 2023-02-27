using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;





public class startGame : MonoBehaviour
{


    public Collider headCollider;


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider == headCollider)
        {
            SceneManager.LoadScene("stage one");

        }

    }
}
