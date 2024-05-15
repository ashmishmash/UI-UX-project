using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    [SerializeField]
    public int TotalMoney = 100;
    public TextMeshProUGUI text;
    public TextMeshProUGUI text2;


    public int AxePrice;
    public int PotionPrice;
    public int SkullPrice;
    public int GemPrice;
    public int DaggerPrice;
    public int AmuletPrice;
    public int ScrollPrice;
    public int BreadPrice;
    public int WandPrice;

    private void Start()
    {
        SetPrices();
    }
    public void SetPrices()
    {
        AxePrice = 10;
        PotionPrice = 5;
        SkullPrice = 15;
        GemPrice = 20;
        DaggerPrice = 5;
        AmuletPrice = 15;
        ScrollPrice = 5;
        BreadPrice = 10;
        WandPrice = 15;
    }
    public void SetTotal(int NewAmount)
    {
      text.text = "$" + NewAmount.ToString();
      text2.text = "$" + NewAmount.ToString();


        if (NewAmount == 0)
        {
            text.color = Color.red;
        }
        else
        {
            text.color = Color.black;
        }
    }
}