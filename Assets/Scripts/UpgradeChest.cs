using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeChest : MonoBehaviour
{
    public ChestManager chestManager;
    public GameObject addButton;

    public GameObject CoverBlock10;
    public GameObject CoverBlock11;
    public GameObject CoverBlock12;
    public GameObject CoverBlock13;
    public GameObject CoverBlock14;
    public GameObject CoverBlock15;
    public GameObject CoverBlock16;

    public MoneyManager moneyManager;

    public void addSlot()
    {
        if (moneyManager.TotalMoney >= 5)
        {
            moneyManager.TotalMoney -= 5;
            moneyManager.SetTotal(moneyManager.TotalMoney);

            if (chestManager.ChestSlot9.activeInHierarchy == false)
            {
                chestManager.ChestSlot9.SetActive(true);
                Object.DestroyImmediate(CoverBlock10);
                addButton.transform.position = chestManager.ChestSlot10.transform.position;
            }
            else if (chestManager.ChestSlot10.activeInHierarchy == false)
            {
                chestManager.ChestSlot10.SetActive(true);
                Object.Destroy(CoverBlock11);
                addButton.transform.position = chestManager.ChestSlot11.transform.position;
            }
            else if (chestManager.ChestSlot11.activeInHierarchy == false)
            {
                chestManager.ChestSlot11.SetActive(true);
                Object.Destroy(CoverBlock12);
                addButton.transform.position = chestManager.ChestSlot12.transform.position;
            }
            else if (chestManager.ChestSlot12.activeInHierarchy == false)
            {
                chestManager.ChestSlot12.SetActive(true);
                Object.Destroy(CoverBlock13);
                addButton.transform.position = chestManager.ChestSlot13.transform.position;
            }
            else if (chestManager.ChestSlot13.activeInHierarchy == false)
            {
                chestManager.ChestSlot13.SetActive(true);
                Object.Destroy(CoverBlock14);
                addButton.transform.position = chestManager.ChestSlot14.transform.position;
            }
            else if (chestManager.ChestSlot14.activeInHierarchy == false)
            {
                chestManager.ChestSlot14.SetActive(true);
                Object.Destroy(CoverBlock15);
                addButton.transform.position = chestManager.ChestSlot15.transform.position;
            }
            else if (chestManager.ChestSlot15.activeInHierarchy == false)
            {
                chestManager.ChestSlot15.SetActive(true);
                Object.Destroy(CoverBlock16);
                addButton.transform.position = chestManager.ChestSlot16.transform.position;
            }
            else if (chestManager.ChestSlot16.activeInHierarchy == false)
            {
                chestManager.ChestSlot16.SetActive(true);
                Object.Destroy(addButton);
            }
        }


    }
}
