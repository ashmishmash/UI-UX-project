using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
//using static UnityEditor.Progress;
using UnityEditor;
using Unity.VisualScripting;

public class BuyItemManager : MonoBehaviour
{
    public MoneyManager moneyManager;
    public BagManager bagManager;

    public GameObject Axe;
    public GameObject Potion;
    public GameObject Skull;
    public GameObject Gem;
    public GameObject Dagger;
    public GameObject Amulet;
    public GameObject Scroll;
    public GameObject Bread;
    public GameObject Wand;

    public Transform StorageSlotArea;

    public int bagid = 0;

 
    public void DeactivateButtonOnClonedItem(GameObject clonedItem)
    {
        Button button = clonedItem.GetComponent<Button>();
        Destroy(button);
    }

    public void BuyItem1()
    {
        if (moneyManager.TotalMoney >= moneyManager.AxePrice)
        {
            GameObject CloneLocation = bagManager.WhichSlot();
            
            if (CloneLocation != null)
            {
                Axe.GetComponent<Identifier>().Bagid = bagid;
                moneyManager.TotalMoney = moneyManager.TotalMoney - moneyManager.AxePrice;
                moneyManager.SetTotal(moneyManager.TotalMoney);
                
         
                GameObject ClonedItem = Instantiate(Axe, CloneLocation.transform.position, Quaternion.identity, CloneLocation.transform);
                ClonedItem.transform.position = new Vector3(CloneLocation.transform.position.x, CloneLocation.transform.position.y, 0);
                RectTransform rectTransform = ClonedItem.GetComponent<Image>().rectTransform;
                Vector3 sizeDelta = rectTransform.sizeDelta;
                sizeDelta.z = -100;
                rectTransform.sizeDelta = sizeDelta;
                ClonedItem.transform.rotation = Axe.transform.rotation;
                ClonedItem.AddComponent<DraggableObject>();
                ClonedItem.GetComponent<Resell>().ActivateScript();
                
                DeactivateButtonOnClonedItem(ClonedItem);
            }
        }
    }

    public void BuyItem2()
    {
        if (moneyManager.TotalMoney >= moneyManager.PotionPrice)
        {
            GameObject CloneLocation = bagManager.WhichSlot();
            if (CloneLocation != null)
            {
                Potion.GetComponent<Identifier>().Bagid = bagid;
                moneyManager.TotalMoney = moneyManager.TotalMoney - moneyManager.PotionPrice;
                moneyManager.SetTotal(moneyManager.TotalMoney);

                GameObject ClonedItem = Instantiate(Potion, CloneLocation.transform.position, Quaternion.identity, CloneLocation.transform);
                ClonedItem.transform.position = new Vector3(CloneLocation.transform.position.x, CloneLocation.transform.position.y, -4);
                ClonedItem.transform.rotation = Potion.transform.rotation;
                ClonedItem.AddComponent<DraggableObject>();
                ClonedItem.GetComponent<Resell>().ActivateScript();
                DeactivateButtonOnClonedItem(ClonedItem);
            }
        }
    }
    public void BuyItem3()
    {
        if (moneyManager.TotalMoney >= moneyManager.SkullPrice)
        {
            GameObject CloneLocation = bagManager.WhichSlot();
            if (CloneLocation != null)
            {
                Skull.GetComponent<Identifier>().Bagid = bagid;
                moneyManager.TotalMoney = moneyManager.TotalMoney - moneyManager.SkullPrice;
                moneyManager.SetTotal(moneyManager.TotalMoney);

                GameObject ClonedItem = Instantiate(Skull, CloneLocation.transform.position, Quaternion.identity, CloneLocation.transform);
                ClonedItem.transform.position = new Vector3(CloneLocation.transform.position.x, CloneLocation.transform.position.y, -4);
                ClonedItem.transform.rotation = Skull.transform.rotation;
                ClonedItem.AddComponent<DraggableObject>();
                ClonedItem.GetComponent<Resell>().ActivateScript();
                DeactivateButtonOnClonedItem(ClonedItem);
            }
        }
    }

    public void BuyItem4()
    {
        if (moneyManager.TotalMoney >= moneyManager.GemPrice)
        {
            GameObject CloneLocation = bagManager.WhichSlot();
            if (CloneLocation != null)
            {
                Gem.GetComponent<Identifier>().Bagid = bagid;
                moneyManager.TotalMoney = moneyManager.TotalMoney - moneyManager.GemPrice;
                moneyManager.SetTotal(moneyManager.TotalMoney);

                GameObject ClonedItem = Instantiate(Gem, CloneLocation.transform.position, Quaternion.identity, CloneLocation.transform);
                ClonedItem.transform.position = new Vector3(CloneLocation.transform.position.x, CloneLocation.transform.position.y, -4);
                ClonedItem.transform.rotation = Gem.transform.rotation;
                ClonedItem.AddComponent<DraggableObject>();
                ClonedItem.GetComponent<Resell>().ActivateScript();
                DeactivateButtonOnClonedItem(ClonedItem);
            }
        }
    }

    public void BuyItem5()
    {
        if (moneyManager.TotalMoney >= moneyManager.DaggerPrice)
        {
            GameObject CloneLocation = bagManager.WhichSlot();
            if (CloneLocation != null)
            {
                Dagger.GetComponent<Identifier>().Bagid = bagid;
                moneyManager.TotalMoney = moneyManager.TotalMoney - moneyManager.DaggerPrice;
                moneyManager.SetTotal(moneyManager.TotalMoney);

                GameObject ClonedItem = Instantiate(Dagger, CloneLocation.transform.position, Quaternion.identity, CloneLocation.transform);
                ClonedItem.transform.position = new Vector3(CloneLocation.transform.position.x, CloneLocation.transform.position.y, -4);
                ClonedItem.transform.rotation = Dagger.transform.rotation;
                ClonedItem.AddComponent<DraggableObject>();
                ClonedItem.GetComponent<Resell>().ActivateScript();
                DeactivateButtonOnClonedItem(ClonedItem);
            }
        }
    }

    public void BuyItem6()
    {
        if (moneyManager.TotalMoney >= moneyManager.AmuletPrice)
        {
            GameObject CloneLocation = bagManager.WhichSlot();
            if (CloneLocation != null)
            {
                Amulet.GetComponent<Identifier>().Bagid = bagid;
                moneyManager.TotalMoney = moneyManager.TotalMoney - moneyManager.AmuletPrice;
                moneyManager.SetTotal(moneyManager.TotalMoney);

                GameObject ClonedItem = Instantiate(Amulet, CloneLocation.transform.position, Quaternion.identity, CloneLocation.transform);
                ClonedItem.transform.position = new Vector3(CloneLocation.transform.position.x, CloneLocation.transform.position.y, -4);
                ClonedItem.transform.rotation = Amulet.transform.rotation;
                ClonedItem.AddComponent<DraggableObject>();
                ClonedItem.GetComponent<Resell>().ActivateScript();
                DeactivateButtonOnClonedItem(ClonedItem);
            }
        }
    }

    public void BuyItem7()
    {
        if (moneyManager.TotalMoney >= moneyManager.ScrollPrice)
        {
            GameObject CloneLocation = bagManager.WhichSlot();
            if (CloneLocation != null)
            {
                Scroll.GetComponent<Identifier>().Bagid = bagid;
                moneyManager.TotalMoney = moneyManager.TotalMoney - moneyManager.ScrollPrice;
                moneyManager.SetTotal(moneyManager.TotalMoney);

                GameObject ClonedItem = Instantiate(Scroll, CloneLocation.transform.position, Quaternion.identity, CloneLocation.transform);
                ClonedItem.transform.position = new Vector3(CloneLocation.transform.position.x, CloneLocation.transform.position.y, -4);
                ClonedItem.transform.rotation = Scroll.transform.rotation;
                ClonedItem.AddComponent<DraggableObject>();
                ClonedItem.GetComponent<Resell>().ActivateScript();
                DeactivateButtonOnClonedItem(ClonedItem);
            }
        }
    }

    public void BuyItem8()
    {
        if (moneyManager.TotalMoney >= moneyManager.BreadPrice)
        {
            GameObject CloneLocation = bagManager.WhichSlot();
            if (CloneLocation != null)
            {
                Bread.GetComponent<Identifier>().Bagid = bagid;
                moneyManager.TotalMoney = moneyManager.TotalMoney - moneyManager.BreadPrice;
                moneyManager.SetTotal(moneyManager.TotalMoney);

                GameObject ClonedItem = Instantiate(Bread, CloneLocation.transform.position, Quaternion.identity, CloneLocation.transform);
                ClonedItem.transform.position = new Vector3(CloneLocation.transform.position.x, CloneLocation.transform.position.y, -4);
                ClonedItem.transform.rotation = Bread.transform.rotation;
                ClonedItem.AddComponent<DraggableObject>();
                ClonedItem.GetComponent<Resell>().ActivateScript();
                DeactivateButtonOnClonedItem(ClonedItem);
            }
        }
    }
    public void BuyItem9()
    {
        if (moneyManager.TotalMoney >= moneyManager.WandPrice)
        {
            GameObject CloneLocation = bagManager.WhichSlot();
            if (CloneLocation != null)
            {
                Wand.GetComponent<Identifier>().Bagid = bagid;
                moneyManager.TotalMoney = moneyManager.TotalMoney - moneyManager.WandPrice;
                moneyManager.SetTotal(moneyManager.TotalMoney);

                GameObject ClonedItem = Instantiate(Wand, CloneLocation.transform.position, Quaternion.identity, CloneLocation.transform);
                ClonedItem.transform.position = new Vector3(CloneLocation.transform.position.x, CloneLocation.transform.position.y, -4);
                ClonedItem.transform.rotation = Wand.transform.rotation;
                ClonedItem.AddComponent<DraggableObject>();
                ClonedItem.GetComponent<Resell>().ActivateScript();
                DeactivateButtonOnClonedItem(ClonedItem);
            }
        }
    }
}
