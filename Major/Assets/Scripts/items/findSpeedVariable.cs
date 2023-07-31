using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class findSpeedVariable : MonoBehaviour
{
   
    public itemManager itemManager;
    public GameObject grabEffect;
    public GameObject item;

    public void OnSelectEnter(XRBaseInteractor interactor)
    {
        int shoeTemp = itemManager.horseShoeAmount;
        itemManager.horseShoeAmount = shoeTemp + 1;

        GameObject grabEffectActive = Instantiate(grabEffect);
        grabEffectActive.transform.position = item.transform.position;

        Destroy(gameObject);
    }
}
