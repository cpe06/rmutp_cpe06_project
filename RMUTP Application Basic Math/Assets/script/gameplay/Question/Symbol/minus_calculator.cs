using UnityEngine;
using System.Collections;

public class minus_calculator : MonoBehaviour
{
    public GenerateQuestion_A GenA;
    public GenerateQuestion_B GenB;
    public int num1, num2, ans;
    public bool done = false;
    void Update()
    {
        if (GenA.done && GenB.done && !done)
        {
            num1 = GenA.transform.childCount;
            num2 = GenB.transform.childCount;
            ans = num1 - num2;
            done = true;
        }
    }
}
