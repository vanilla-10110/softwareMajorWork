using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHitReg : MonoBehaviour
{
    public float enemyHealth = 100f;
    public Rigidbody rb;
    public WeaponScript playerWeapon;

    public GameObject ragDoll;
    public GameObject enemy;

    void Start()
    {
        playerWeapon = GameObject.Find("PlayerWeapon").GetComponent<WeaponScript>();
    }

    private void Update()
    {
        if (enemyHealth <= 0) 
        {
            Debug.Log("wow me be deds");
            enemyHealth = 100f;
            enemy.SetActive(false);
            ragDoll.SetActive(true);
            ragDoll.transform.position = enemy.transform.position;
            ragDoll.transform.rotation = enemy.transform.rotation;

        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Weapon")
        {
            float playerDamage = playerWeapon.damage; 
            enemyHealth -= playerDamage;
            Debug.Log("Dealt " + playerDamage + " Damage.");
        }
    }
}
