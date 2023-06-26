using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHitReg : MonoBehaviour
{
    public float enemyHealth = 100f;
    public Rigidbody rb;
    public WeaponScript playerWeapon;

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
