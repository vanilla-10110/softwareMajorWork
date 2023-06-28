using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHitReg : MonoBehaviour
{
    public float enemyHealth = 100f;
    public float forceMagnitude = 8f;
    public Rigidbody rb;
    public WeaponScript playerWeapon;

    public GameObject ragDoll;
    public GameObject enemy;
    public Rigidbody ragDollRB;

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
            ragDollRB.AddForce(-transform.forward * forceMagnitude, ForceMode.Impulse);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Weapon"))
        {
            float playerDamage = playerWeapon.damage;
            TakeDamage(playerDamage);
            Debug.Log("Dealt " + playerDamage + " Damage.");
        }
    }

    private void TakeDamage(float damage)
    {
        enemyHealth -= damage;
        if (enemyHealth <= 0)
        {
            enemy.SetActive(false);
            ragDoll.SetActive(true);
            ragDoll.transform.position = enemy.transform.position;
            ragDoll.transform.rotation = enemy.transform.rotation;
            ragDollRB.AddForce(-transform.forward * forceMagnitude, ForceMode.Impulse);
        }
    }
}
