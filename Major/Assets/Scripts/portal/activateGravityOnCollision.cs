using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateGravityOnCollision : MonoBehaviour
{
    public Rigidbody crystalRB;
    public GameObject crystal;

    private void OnCollisionEnter(Collision collision)
    {
        crystal.layer = 10;
        crystalRB.useGravity = true;

    }
}