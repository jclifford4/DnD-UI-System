using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SumRolls : MonoBehaviour
{
    public TMP_Text box1, box2, box3, box4;
    private int one, two, three;



    public void sumRolls()
    {
        box4.text = convertToInt().ToString();
    }

    private int convertToInt()
    {
        one = int.Parse(box1.text);
        two = int.Parse(box2.text);
        three = int.Parse(box3.text);

        return one + two + three;
    }


}
