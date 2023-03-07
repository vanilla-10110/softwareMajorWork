using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handPhysics : MonoBehaviour
{
    [SerializeField] private GameObject followObject;
    [SerializeField] private float followSpeed = 30f;
    [SerializeField] private float rotateSpeed = 100f;
    private Transform followTarget;
    private Rigidbody body;

    private void Start()
    {
        followTarget = followObject.transform;
        body = GetComponent<Rigidbody>();
        body.collisionDetectionMode = CollisionDetectionMode.Continuous;
        body.interpolation = RigidbodyInterpolation.Interpolate;
        body.mass = 20f;

        //Teleport hands
        body.position = followTarget.position;
        body.rotation = followTarget.rotation;
    }

    private void Update()
    {
        PhysicsMove();
    }


    private void PhysicsMove()
    {
        //Position
        var distance = Vector3.Distance(followTarget.position, transform.position);
        body.velocity = ((followTarget.position - transform.position).normalized  * (followSpeed * distance));


        //Rotation
    }
}
