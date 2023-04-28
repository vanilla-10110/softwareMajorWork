using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GrabPhysics : MonoBehaviour
{
    public InputActionProperty grabInputSource;
    public float radius = 0.1f;
    public LayerMask grabLayer;
    
    public Collider handCollider;
    public InputActionProperty isTriggerInputSource;

    private FixedJoint fixedJoint;
    private bool isGrabbing = false;

   


    void Update()
    {
        //detects if x button is pressed
        bool xInput = isTriggerInputSource.action.WasPressedThisFrame();
        if (xInput)
        {
            handCollider.isTrigger = !handCollider.isTrigger;
        }

        //detects if grab button is pressed past 0.1
        bool isGrabButtonPressed = grabInputSource.action.ReadValue<float>() > 0.1f;
        
        //grab script
        if (isGrabButtonPressed && !isGrabbing)
        {   //sets parameters for the "nearbyColliders" array
            Collider[] nearbyColliders = Physics.OverlapSphere(transform.position, radius, grabLayer, QueryTriggerInteraction.Ignore);

            if(nearbyColliders.Length > 0)
            {   //sets the RB of the closest RB to the 1st item in the array
                Rigidbody nearbyRigidbody = nearbyColliders[0].attachedRigidbody;
                //create a fixed joint
                fixedJoint = gameObject.AddComponent<FixedJoint>();
                fixedJoint.autoConfigureConnectedAnchor = false;

                if (nearbyRigidbody)
                {   //attatches the RB to the hand
                    fixedJoint.connectedBody = nearbyRigidbody;
                    fixedJoint.connectedAnchor = nearbyRigidbody.transform.InverseTransformPoint(transform.position);
                
                }
                else
                {   //attatches the hand to the world
                    fixedJoint.connectedAnchor = transform.position;
                }

                isGrabbing = true;
            }
        }
        else if(!isGrabButtonPressed && isGrabbing)
        {   //stop grabbing
            isGrabbing = false;

            if (fixedJoint)
            {
                Destroy(fixedJoint);
            }
        }
    }
}
