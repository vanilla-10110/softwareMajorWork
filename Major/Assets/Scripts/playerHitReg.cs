using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerHitReg : MonoBehaviour
{
    public float playerHealth = 100f;
    public float forceMagnitude = 8f;
    public Rigidbody rb;
    WeaponScript enemyWeapon;

    public GameObject ragDoll;
    public GameObject player;
    public Rigidbody ragDollRB;

    void Start()
    {
        GameObject weaponGameObject = GameObject.FindGameObjectWithTag("enemyWeapon");
        if (weaponGameObject != null)
        {
            enemyWeapon = weaponGameObject.GetComponent<WeaponScript>();
        }
        else
        {
            Debug.LogError("No weapon GameObject found with the 'Weapon' tag.");
        }
    }


    private void Update()
    {
        if (playerHealth <= 0)
        {
            Debug.Log("wow me be deds");
            playerHealth = 100f;
            SceneManager.LoadScene("armoury");
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("enemyWeapon"))
        {
            float enemyDamage = enemyWeapon.damage;
            TakeDamage(enemyDamage);
            Debug.Log("Enemy Dealt " + enemyDamage + " Damage.");
        }
    }

    private void TakeDamage(float damage)
    {
        playerHealth -= damage;
        if (playerHealth <= 0)
        {
            SceneManager.LoadScene("armoury");
        }
    }
}
