using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

[System.Serializable]
public class OutputCharacter: MonoBehaviour
{
    //[SerializeField] public TMPro.TextMeshProUGUI txt;
    //public TMPro.TMP_Text text;
    public TMPro.TMP_InputField box;

    public void outputCharacter()
    {
        string json = File.ReadAllText(Application.dataPath + "/CharacterData.json").TrimEnd();
        //text.text = parseJson(json);
        box.text = parseJson(json);
        Debug.Log(box.text);
    }

    public string parseJson(string json)
    {
        string[] words = json.Split('\n');
        string parsedJson = "";
        foreach (var word in words)
        {
            parsedJson += word;
        }
        return parsedJson;
    }


}
