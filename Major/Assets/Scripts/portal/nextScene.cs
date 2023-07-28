using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextScene : MonoBehaviour
{
    public Collider headCollider;
    public GameObject player;

    public GameObject nextStage;
    public GameObject prevStage;

    public Transform tpPos;
    
    




    private IEnumerator OnTriggerEnter(Collider collision)
    {

        if (collision.GetComponent<Collider>() == headCollider)
        {
            nextStage.SetActive(true);

            yield return new WaitForSeconds(3);

            player.transform.position = tpPos.position;
            prevStage.SetActive(false);

        }
    }


}
