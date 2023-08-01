using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startGame : MonoBehaviour
{
    public Collider headCollider;
    public GameObject player;

    
    public GameObject prevStage;

    public Transform tpPos;






    private IEnumerator OnTriggerEnter(Collider collision)
    {

        if (collision.GetComponent<Collider>() == headCollider)
        {
            

            yield return new WaitForSeconds(3);

            player.transform.position = tpPos.position;
            prevStage.SetActive(false);

        }
    }


}
