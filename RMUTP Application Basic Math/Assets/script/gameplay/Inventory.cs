using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System;
using UnityEngine.UI;

public class Inventory : MonoBehaviour, IHasChanged {
    [SerializeField] Transform slots;
    [SerializeField] Text inventoryText;
    public string number;
    public int answer,num1,num2,num3,result = 100;
    public GenerateQuestion_A genA;
    public GenerateQuestion_B genB;
    public modeSelect modeSelect;

    void Start () {
        HasChanged();
	}

    public void HasChanged()
    {
        System.Text.StringBuilder builder = new System.Text.StringBuilder();
        System.Text.StringBuilder builderTemp = new System.Text.StringBuilder();
        foreach(Transform slotTransform in slots)
        {
            GameObject item = slotTransform.GetComponent<SlotNumber>().item;
            if (item)
            {
                switch (item.name)
                {
                    case "0": number = "๐"; break;
                    case "1": number = "๑"; break;
                    case "2": number = "๒"; break;
                    case "3": number = "๓"; break;
                    case "4": number = "๔"; break;
                    case "5": number = "๕"; break;
                    case "6": number = "๖"; break;
                    case "7": number = "๗"; break;
                    case "8": number = "๘"; break;
                    case "9": number = "๙"; break;
                }
                builder.Append(number);
                builderTemp.Append(item.name);
            }
        }
        inventoryText.text = builder.ToString();
        num1 = (int)genA.quest_Number_A;
        num2 = (int)genB.quest_Number_B;
        switch (modeSelect.currentMode)
        {
            case 0:
                answer = num1 + num2;
                break;
            case 1:
                answer = num1 - num2;
                break;
            default:
                answer = num1 + num2;
                break;
        }
        result = int.Parse(builderTemp.ToString()) - answer;
        if (result == 0)
        {
            inventoryText.text = builder.ToString() + " ถูกต้อง";
        }

    }
}

namespace UnityEngine.EventSystems
{
    public interface IHasChanged : IEventSystemHandler
    {
        void HasChanged();
    }
}