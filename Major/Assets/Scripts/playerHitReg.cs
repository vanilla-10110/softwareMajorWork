using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerHitReg : MonoBehaviour
{
    public float playerHealth = 100f;
    public float forceMagnitude = 8f;
    public Rigidbody rb;
    ememyWeaponScript enemyWeapon;

    public GameObject ragDoll;
    public GameObject player;
    public Rigidbody ragDollRB;

    private void Update()
    {
        if (playerHealth <= 0)
        {
            Debug.Log("wow me be deds");
            playerHealth = 100f;
            SceneManager.LoadScene("armoury");
        }
    }

    void OnTriggerEnter(Collider collision)
    {
        Debug.Log("nuh uh");
        if (collision.gameObject.CompareTag("enemyWeapon"))
        {
            Debug.Log("yuh huh");
            
            TakeDamage(5f);
            Debug.Log("Enemy Dealt 5 Damage.");
        }
    }

    private void TakeDamage(float damage)
    {
        playerHealth -= damage;
        if (playerHealth <= 0)
        {
            Debug.Log("IVE BEEN FUCKING KILLED WHAT THE FUCK");
            Application.Quit();
        }
    }
}
