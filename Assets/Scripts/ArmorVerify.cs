using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class ArmorVerify : MonoBehaviour
{

    public TMP_InputField armorField;



    public void verifyDigits()
    {
        string txt = armorField.text;
        int val = 0;
        for (int i = 0; i < txt.Length; i++)
        {
            val += txt[i];
        }
        Debug.Log(val);

        Regex regx = new Regex("[^0-9]+");

        if ((regx.IsMatch(txt)) || (((val < 49) || (val > 145))))
        {
            Debug.Log("ERROR, MAX NUMBER IS 100");
            Debug.Log("ASSIGNING A RANDOM NUMBER (1-100)");
            armorField.text = Random.Range(1, 101).ToString();
        }


    }
}

