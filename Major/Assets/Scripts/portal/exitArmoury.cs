using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exitArmoury : MonoBehaviour
{
    public Collider headCollider;
    public GameObject player;

    public GameObject nextStage;
    

    public Transform tpPos;



    private IEnumerator OnTriggerEnter(Collider collision)
    {

        if (collision.GetComponent<Collider>() == headCollider)
        {
            nextStage.SetActive(true);

            yield return new WaitForSeconds(3);

            player.transform.position = tpPos.position;
            

        }
    }


}
