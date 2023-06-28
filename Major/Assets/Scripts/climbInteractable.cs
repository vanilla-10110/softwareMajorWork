using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class climbInteractable : XRBaseInteractable
{
    protected override void OnSelectEntered(XRBaseInteractor interactor)
    {
        base.OnSelectEntered(interactor);

        if (interactor is XRDirectInteractor)
        {
            climber.climbingHand = interactor.GetComponent<XRController>();
        }
    }

    protected override void OnSelectExited(XRBaseInteractor interactor)
    {
        base.OnSelectExited(interactor);

        if (interactor is XRDirectInteractor)
        {
            if (climber.climbingHand && climber.climbingHand.name == interactor.name)
            {
                climber.climbingHand = null;
            }
        }
    }
}