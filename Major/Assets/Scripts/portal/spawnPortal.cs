using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
// this is vishnu kumar

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
   
    
    
    private void OnCollisionEnter(Collision collision)
    {




        if(collision.collider == redCrystalCollider)
        {
            portalRed.SetActive(true);
            portalYellow.SetActive(false);
            portalGreen.SetActive(false);

            redCrystalPos.position = redPos.position;
            redCrystalPos.rotation = redPos.rotation;
            redRB.velocity = Vector3.zero;
            redRB.useGravity = false;
            redCrystal.layer = 12;
            
        }
           else if(collision.collider == yellowCrystalCollider)
        {
            portalYellow.SetActive(true);
            portalRed.SetActive(false);
            portalGreen.SetActive(false);

            yellowCrystalPos.position = yellowPos.position;
            yellowCrystalPos.rotation = yellowPos.rotation;
            yellowRB.velocity = Vector3.zero;
            yellowRB.useGravity = false;
            yellowCrystal.layer = 12;
        }
            else if(collision.collider == greenCrystalCollider)
        {
            portalGreen.SetActive(true);
            portalRed.SetActive(false);
            portalYellow.SetActive(false);

            greenCrystalPos.position = greenPos.position;
            greenCrystalPos.rotation = greenPos.rotation;
            greenRB.velocity = Vector3.zero;
            greenRB.useGravity = false;
            greenCrystal.layer = 12;
        }
        





        //Debug.Log("Collision detected at " + collision.contacts[0].point + " with a velocity of " + collision.relativeVelocity.magnitude);
    }
}
