using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    public GameObject BagSlot1;
    public GameObject BagSlot2;
    public GameObject BagSlot3;
    public GameObject BagSlot4;
    public GameObject BagSlot5;
    public GameObject BagSlot6;
    public GameObject BagSlot7;
    public GameObject BagSlot8;
    public GameObject BagSlot9;

    public TextMeshProUGUI text;

    public Resell resell;
    public BagManager bagManager;
    Vector3 newPosition = new Vector3(8.93f, 0f,-10f);
    Vector3 oldPosition = new Vector3(0f, 0f, -10f);
    // Start is called before the first frame update
   
    public void OnChestClick()
    {
        Camera.main.transform.position = newPosition;
        text.enabled = false;
        for (int i = 1;  i < bagManager.SlotsUsed +1; i++)
        {
            switch (i)
            {
                case 1:
                    BagSlot1.GetComponentInChildren<Resell>().activated = false;
                    break;
                case 2:
                    BagSlot2.GetComponentInChildren<Resell>().activated = false;
                    break;
                case 3:
                    BagSlot3.GetComponentInChildren<Resell>().activated = false;
                    break;
                case 4:
                    BagSlot4.GetComponentInChildren<Resell>().activated = false;
                    break;
                case 5:
                    BagSlot5.GetComponentInChildren<Resell>().activated = false;
                    break;
                case 6:
                    BagSlot6.GetComponentInChildren<Resell>().activated = false;
                    break;
                case 7:
                    BagSlot7.GetComponentInChildren<Resell>().activated = false;
                    break;
                case 8:
                    BagSlot8.GetComponentInChildren<Resell>().activated = false;
                    break;
                case 9:
                    BagSlot9.GetComponentInChildren<Resell>().activated = false;
                    break;

            }
        }
    }

    public void OnShopClick()
    {
        Camera.main.transform.position = oldPosition;
        text.enabled = true;
        for (int i = 1; i < bagManager.SlotsUsed + 1; i++)
        {
            switch (i)
            {
                case 1:
                    BagSlot1.GetComponentInChildren<Resell>().activated = true;
                    break;
                case 2:
                    BagSlot2.GetComponentInChildren<Resell>().activated = true;
                    break;
                case 3:
                    BagSlot3.GetComponentInChildren<Resell>().activated = true;
                    break;
                case 4:
                    BagSlot4.GetComponentInChildren<Resell>().activated = true;
                    break;
                case 5:
                    BagSlot5.GetComponentInChildren<Resell>().activated = true;
                    break;
                case 6:
                    BagSlot6.GetComponentInChildren<Resell>().activated = true;
                    break;
                case 7:
                    BagSlot7.GetComponentInChildren<Resell>().activated = true;
                    break;
                case 8:
                    BagSlot8.GetComponentInChildren<Resell>().activated = true;
                    break;
                case 9:
                    BagSlot9.GetComponentInChildren<Resell>().activated = true;
                    break;

            }
        }
    }
}
