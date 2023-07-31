using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class findCritVariable : MonoBehaviour
{

    public itemManager itemManager;

    public void OnSelectEnter(XRBaseInteractor interactor)
    {
        int critTemp = itemManager.critAmount;
        itemManager.critAmount = critTemp + 1;

        Debug.Log(itemManager.critAmount);
        Destroy(gameObject);
    }
}