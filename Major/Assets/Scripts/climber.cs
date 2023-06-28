using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class climber : MonoBehaviour
{
    private CharacterController character;
    public static XRController climbingHand;
    private ActionBasedContinuousMoveProvider continuousMovement;

    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<CharacterController>();
        continuousMovement = GetComponent<ActionBasedContinuousMoveProvider>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (climbingHand)
        {
            continuousMovement.enabled = false;
            Climb();
        }
    }

   //Climbing Computations
        void Climb()
        {
        InputDevices.GetDeviceAtXRNode(climbingHand.controllerNode).TryGetFeatureValue(CommonUsages.deviceVelocity, out Vector3 velocity);

        character.Move(transform.rotation * -velocity * Time.fixedDeltaTime);
        }
    

}
