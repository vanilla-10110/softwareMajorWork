using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class findSpeedVariable : MonoBehaviour
{
   
    public itemManager itemManager;

    public void OnSelectEnter(XRBaseInteractor interactor)
    {
        int shoeTemp = itemManager.horseShoeAmount;
        itemManager.horseShoeAmount = shoeTemp + 1;
        Destroy(gameObject);
    }
}
