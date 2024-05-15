using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BagManager : MonoBehaviour
{
    public int SlotsUsed = 0;

    public GameObject BagSlot1;
    public GameObject BagSlot2;
    public GameObject BagSlot3;
    public GameObject BagSlot4;
    public GameObject BagSlot5;
    public GameObject BagSlot6;
    public GameObject BagSlot7;
    public GameObject BagSlot8;
    public GameObject BagSlot9;

    public bool canHold1 = true;
    public bool canHold2 = true;
    public bool canHold3 = true;
    public bool canHold4 = true;
    public bool canHold5 = true;
    public bool canHold6 = true;
    public bool canHold7 = true;
    public bool canHold8 = true;
   public  bool canHold9 = true;

    public int bagID;

    public BuyItemManager buyItem;
   
    public void SetSlotOpen(int bagid)
    {
        if (SlotsUsed != 0)
        {
            switch (bagid)
            {
                case 1:
                    SlotsUsed--;
                    canHold1 = true;
                    break;
                case 2:
                    SlotsUsed--;
                    canHold2 = true;
                    break;
                case 3:
                    SlotsUsed--;
                    canHold3 = true;
                    break;
                case 4:
                    SlotsUsed--;
                    canHold4 = true;
                    break;
                case 5:
                    SlotsUsed--;
                    canHold1 = true;
                    break;
                case 6:
                    SlotsUsed--;
                    canHold6 = true;
                    break;
                case 7:
                    SlotsUsed--;
                    canHold7 = true;
                    break;
                case 8:
                    SlotsUsed--;
                    canHold8 = true;
                    break;
                case 9:
                    SlotsUsed--;
                    canHold9 = true;
                    break;
            }
        }
            

        }
    public GameObject WhichSlot()
    {
        if (canHold1 == true)
        {
            buyItem.bagid = 1;
            bagID = 1;
            SlotsUsed++;
            canHold1 = false;
            return BagSlot1;   
        }
        else if (canHold2 == true)
        {
            buyItem.bagid = 2;
            bagID = 2;
            SlotsUsed ++;
            canHold2 = false;
            return BagSlot2;
        }
        else if (canHold3 == true)
        {
            buyItem.bagid = 3;
            bagID = 3;
            SlotsUsed ++;
            canHold3 = false;
            return BagSlot3;
        }
        else if (canHold4 == true)
        {
            buyItem.bagid = 4;
            bagID = 4;
            SlotsUsed ++;
            canHold4 = false;
            return BagSlot4;
        }
        else if (canHold5 == true)
        {
            buyItem.bagid = 5;
            bagID = 5;
            SlotsUsed ++;
            canHold5 = false;
            return BagSlot5;
        }
        else if (canHold6 == true)
        {
            buyItem.bagid = 6;
            bagID = 6;
            SlotsUsed ++;
            canHold6 = false;
            return BagSlot6;
        }
        else if (canHold7 == true)
        {
            buyItem.bagid = 7;
            bagID = 7;
            SlotsUsed ++;
            canHold7 = false;
            return BagSlot7;
        }
        else if (canHold8 == true)
        {
            buyItem.bagid = 8;
            bagID = 8;
            SlotsUsed ++;
            canHold8 = false;
            return BagSlot8;
        }
        else if (canHold9 == true)
        {
            buyItem.bagid = 9;
            bagID = 9;
            SlotsUsed ++;
            canHold9 = false;
            return BagSlot9;   
        }
        else
        {
            return null;
        }    
    }
}