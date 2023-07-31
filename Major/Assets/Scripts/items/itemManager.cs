using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class itemManager : MonoBehaviour
{
    public ActionBasedContinuousMoveProvider continuousMoveProvider;
    float baseMoveSpeed = 2;


    
    public int horseShoeAmount = 0; int shoeTemp = 0;
    public int critAmount = 0; int critTemp = 0; float critChance = 0f;
    public int boomJuiceAmount = 0; int boomTemp = 0;



    private void Update()
    {
        if (horseShoeAmount != shoeTemp)
        {
            speed();
            shoeTemp = horseShoeAmount;
        }
        if (critAmount != critTemp)
        {
            crit();
            critTemp = critAmount;
        }
        if (boomJuiceAmount != boomTemp)
        {
            //boom();
            boomJuiceAmount = boomTemp;
        }

    }
    public void speed()
    {
        float newMoveSpeed = baseMoveSpeed + (0.2f * horseShoeAmount);
        continuousMoveProvider.moveSpeed = newMoveSpeed;
    }
    public void crit()
    {
        float newcrit = 0 + (0.1f * critAmount);
        critChance = newcrit;
        Debug.Log("crit chance = " + critChance);
    }
    /*public void boom()
    {
        float newBoom = 1 * boomJuiceAmount;
    }*/

}
