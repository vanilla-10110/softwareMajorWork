using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeGame : MonoBehaviour
{
    public Collider headCollider;

    private void OnTriggerEnter(Collider collision)
    {

        if (collision.GetComponent<Collider>() == headCollider)
        {
            Debug.Log("yes?");
            Application.Quit();

        }
    }
}
