using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;


public class RandomRoll : MonoBehaviour
{
    public TMP_Text box1;
    
    public void rollDice()
    {
        const int side8 = 8, side3 = 3;
       // int index = 0;
        int max = 0;
        int temp;

        for (int i = 0; i < 5; i++)
        {
            
            temp = UnityEngine.Random.RandomRange(1, side8+ 1);
            //Debug.Log("In 8 roll: " + temp);
            if (temp >= max)
            {
                max = temp;
                temp = 0;
            }

            }

            for (int i = 0; i < 6; i++)
        {
          
            temp = UnityEngine.Random.RandomRange(1, side3+ 1);
            if (temp >= max)
            {
                max = temp;
                temp = 0;
            }
        }

        box1.text = max.ToString();

    }

}





