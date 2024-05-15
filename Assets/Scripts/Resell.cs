using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Resell : MonoBehaviour, IPointerDownHandler
{
    public MoneyManager moneyManager;
    public int counter = 0;
    public BagManager bagManager;

    public bool activated = false;

    void Start()
    {
        // By default, the script will not execute until activated
        enabled = activated;
    }

    // Method to activate the script
    public void ActivateScript()
    {
        activated = true;
        enabled = true;
    }

    // Method to deactivate the script
    public void DeactivateScript()
    {
        activated = false;
        enabled = false;
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        if (activated == true)
        {
            counter++;
            if (counter == 2)
            {
                int Itemid = this.gameObject.GetComponent<Identifier>().id;
                int Bagid = this.gameObject.GetComponent<Identifier>().Bagid;
                SetSlotFalse(Bagid);
                bagManager.SetSlotOpen(Bagid);

                Destroy(this.gameObject);
                switch (Itemid)
                {
                    case 1:
                        moneyManager.TotalMoney += moneyManager.AxePrice;
                        break;
                    case 2:
                        moneyManager.TotalMoney += moneyManager.PotionPrice;
                        break;
                    case 3:
                        moneyManager.TotalMoney += moneyManager.SkullPrice;
                        break;
                    case 4:
                        moneyManager.TotalMoney += moneyManager.GemPrice;
                        break;
                    case 5:
                        moneyManager.TotalMoney += moneyManager.DaggerPrice;
                        break;
                    case 6:
                        moneyManager.TotalMoney += moneyManager.AmuletPrice;
                        break;
                    case 7:
                        moneyManager.TotalMoney += moneyManager.ScrollPrice;
                        break;
                    case 8:
                        moneyManager.TotalMoney += moneyManager.BreadPrice;
                        break;
                    case 9:
                        moneyManager.TotalMoney += moneyManager.WandPrice;
                        break;
                } //end switch
                counter = 0;
                moneyManager.SetTotal(moneyManager.TotalMoney);
            }//end if
        } //end if
    }//end function

    public void SetSlotFalse(int id)
    {
        switch (id)
        {
            case 1:
                bagManager.canHold1 = true;
                break;
            case 2:
                bagManager.canHold2 = true;
                break;
            case 3:
                bagManager.canHold3 = true;
                break;
            case 4:
                bagManager.canHold4 = true;
                break;
            case 5:
                bagManager.canHold5 = true;
                break;
            case 6:
                bagManager.canHold6 = true;
                break;
            case 7:
                bagManager.canHold7 = true;
                break;
            case 8:
                bagManager.canHold8 = true;
                break;
            case 9:
                bagManager.canHold9 = true;
                break;
        }
    }

   
}
