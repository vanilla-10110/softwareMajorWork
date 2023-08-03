using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class findCritVariable : MonoBehaviour
{

    public itemManager itemManager;
    public GameObject grabEffect;
    public GameObject item;
    public void OnSelectEnter(XRBaseInteractor interactor)
    {
        int critTemp = itemManager.critAmount;
        itemManager.critAmount = critTemp + 1;

        GameObject grabEffectActive = Instantiate(grabEffect);
        grabEffectActive.transform.position = item.transform.position;
        
        
        Debug.Log(itemManager.critAmount);
        Destroy(gameObject);
    }
}