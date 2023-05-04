using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class spawnPortal : MonoBehaviour
{
    public Collider portalSpawn;

    public Collider redCrystalCollider;
    public Collider yellowCrystalCollider;
    public Collider greenCrystalCollider;

    public GameObject redCrystal;
    public GameObject yellowCrystal;
    public GameObject greenCrystal;

    public Rigidbody redRB;
    public Rigidbody yellowRB;
    public Rigidbody greenRB;

    public GameObject portalRed;
    public GameObject portalYellow;
    public GameObject portalGreen;

    public Transform redCrystalPos;
    public Transform yellowCrystalPos;
    public Transform greenCrystalPos;

    public Transform redPos;
    public Transform yellowPos;
    public Transform greenPos;


    private void activatePortal(GameObject portal, Transform crystalPos, Transform crystalRestPos, Rigidbody crystalRB)
    {   //spawns the portal and returns the crystal to it's initial position
        portal.SetActive(true);
        crystalPos.position = crystalRestPos.position;
        crystalPos.rotation = crystalRestPos.rotation;
        crystalRB.velocity = Vector3.zero;
        //for "activateGravityOnCollision" script
        crystalRB.useGravity = false;
        crystalRB.gameObject.layer = 12;
    }

    private void OnCollisionEnter(Collision collision)
    {   //detects which crystal was used and removes other portals
        if (collision.collider == redCrystalCollider)
        {
            activatePortal(portalRed, redCrystalPos, redPos, redRB);
            portalYellow.SetActive(false);
            portalGreen.SetActive(false);
        }
        else if (collision.collider == yellowCrystalCollider)
        {
            activatePortal(portalYellow, yellowCrystalPos, yellowPos, yellowRB);
            portalRed.SetActive(false);
            portalGreen.SetActive(false);
        }
        else if (collision.collider == greenCrystalCollider)
        {
            activatePortal(portalGreen, greenCrystalPos, greenPos, greenRB);
            portalRed.SetActive(false);
            portalYellow.SetActive(false);
        }
    }
}
