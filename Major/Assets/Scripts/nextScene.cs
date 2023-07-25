using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextScene : MonoBehaviour
{
    public Collider headCollider;
    public string sceneName;
    public string activeSceneName;

    public int targetSceneIndex;

    public GameObject itemManager;
    public GameObject player;
    public GameObject weapons;




    private void OnTriggerEnter(Collider collision)
    {

        if (collision.GetComponent<Collider>() == headCollider)
        {

        player.transform.position = new Vector3(10, 10, 10);

        }
    }


}
