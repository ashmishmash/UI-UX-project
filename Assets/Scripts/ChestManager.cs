using UnityEngine;

public class ChestManager : MonoBehaviour
{
    public int SlotsUsed = 0;

    public GameObject ChestSlot1;
    public GameObject ChestSlot2;
    public GameObject ChestSlot3;
    public GameObject ChestSlot4;
    public GameObject ChestSlot5;
    public GameObject ChestSlot6;
    public GameObject ChestSlot7;
    public GameObject ChestSlot8;
    public GameObject ChestSlot9;
    public GameObject ChestSlot10;
    public GameObject ChestSlot11;
    public GameObject ChestSlot12;
    public GameObject ChestSlot13;
    public GameObject ChestSlot14;
    public GameObject ChestSlot15;
    public GameObject ChestSlot16;

    public bool canHold1 = true;
    public bool canHold2 = true;
    public bool canHold3 = true;
    public bool canHold4 = true;
    public bool canHold5 = true;
    public bool canHold6 = true;
    public bool canHold7 = true;
    public bool canHold8 = true;
    public bool canHold9 = true;
    public bool canHold10 = true;
    public bool canHold11= true;
    public bool canHold12 = true;
    public bool canHold13= true;
    public bool canHold14= true;
    public bool canHold15= true;
    public bool canHold16= true;

    public int chestID;
    public void SetSlotOpen(int chestid)
    {
        if (SlotsUsed != 0)
        {
            switch (chestid)
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
                case 10:
                    SlotsUsed--;
                    canHold10 = true;
                    break;
                case 11:
                    SlotsUsed--;
                    canHold11 = true;
                    break;
                case 12:
                    SlotsUsed--;
                    canHold12 = true;
                    break;
                case 13:
                    SlotsUsed--;
                    canHold13 = true;
                    break;
                case 14:
                    SlotsUsed--;
                    canHold14 = true;
                    break;
                case 15:
                    SlotsUsed--;
                    canHold15 = true;
                    break;
                case 16:
                    SlotsUsed--;
                    canHold16 = true;
                    break;
            }
        }
        
    }
        public GameObject WhichSlot()
    {
        if (canHold1 == true)
        {
            canHold1 = false;
            SlotsUsed++;
            chestID = 1;
            return ChestSlot1;
        }
        else if (canHold2 == true)
        {
            canHold2 = false;
            SlotsUsed ++;
            chestID = 2;
            return ChestSlot2;
        }
        else if (canHold3 == true)
        {
            canHold3 = false;
            SlotsUsed ++;
            chestID = 3;
            return ChestSlot3;
        }
        else if (canHold4 == true)
        {
            canHold4 = false;
            SlotsUsed ++;
            chestID = 4;
            return ChestSlot4;
        }
        else if (canHold5 == true)
        {
            canHold5 = false;
            SlotsUsed ++;
            chestID = 5;
            return ChestSlot5;
        }
        else if (canHold6 == true)
        {
            canHold6 = false;
            SlotsUsed ++;
            chestID = 6;
            return ChestSlot6;
        }
        else if (canHold7 == true)
        {
            canHold7 = false;
            SlotsUsed ++;
            chestID = 7;
            return ChestSlot7;
        }
        else if (canHold8 == true)
        {
            canHold8 = false;
            SlotsUsed ++;
            chestID = 8;
            return ChestSlot8;
        }
        else if (canHold9 == true)
        {
            canHold9 = false;
            SlotsUsed ++;
            chestID = 9;
            return ChestSlot9;
        }
        else if (canHold10 == true)
        {
            canHold10 = false;
            SlotsUsed ++;
            chestID = 10;
            return ChestSlot10;
        }
        else if (canHold11 == true)
        {
            canHold11 = false;
            SlotsUsed ++;
            chestID = 11;
            return ChestSlot11;
        }
        else if (canHold12 == true)
        {
            canHold12 = false;
            SlotsUsed ++;
            chestID = 12;
            return ChestSlot12;
        }
        else if (canHold13 == true)
        {
            canHold13 = false;
            SlotsUsed ++;
            chestID = 13;
            return ChestSlot13;
        }
        else if (canHold14 == true)
        {
            canHold14 = false;
            SlotsUsed ++;
            chestID = 14;
            return ChestSlot14;
        }
        else if (canHold15 == true)
        {
            canHold15 = false;
            SlotsUsed ++;
            chestID = 15;
            return ChestSlot15;
        }
        else if (canHold16 == true)
        {
            canHold16 = false;
            SlotsUsed ++;
            chestID = 16;
            return ChestSlot16;

        }
        else
        {
            return null;
        }
    }
}
