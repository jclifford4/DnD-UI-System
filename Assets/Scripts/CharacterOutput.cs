using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
public class CharacterOutput : MonoBehaviour
{

    public TMPro.TMP_Text text;



    public void OutputText()
    {
        string json = File.ReadAllText(Application.dataPath + "/CharacterData.json");
        text.text = ParseJson(json);
    }


    public string ParseJson(string json)
    {
        string[] words = json.Split('\n');
        string t = "";
        foreach(var word in words)
        {
            t += word;
        }

        return t;
    }


}
