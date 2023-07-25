using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextScene : MonoBehaviour
{
    public Collider headCollider;
    public string sceneName;


    private void OnTriggerEnter(Collider collision)
    {

        if (collision.GetComponent<Collider>() == headCollider)
        {
            Debug.Log("yes?");
            SceneManager.LoadScene(sceneName);

        }
    }

}
