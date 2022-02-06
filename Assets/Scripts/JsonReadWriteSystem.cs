using System.IO;
using UnityEngine;
using UnityEngine.UI;


public class JsonReadWriteSystem : MonoBehaviour
{
    public TMPro.TMP_InputField curXPInputField, maxXPInputField, nameInputField;
    public TMPro.TMP_InputField curHitInputField, maxHitInputField, armorInputField;
    public TMPro.TMP_Dropdown raceDropdown, classDropdown, alignmentDropdown;
    public TMPro.TMP_Text outputText, strengthText, dexterityText, constitutionText,
                            intelligenceText, wisdomText, charismaText;
    public Slider walkSlider, runSlider, jumpSlider;
    private int rollMod = 2;
    public TMPro.TMP_InputField outputField;
    




    public CharacterData newCharacter()
    {
        CharacterData chData = new CharacterData();

        chData.name = nameInputField.text;
        

        //TODO: Change to int from string
        chData.curXP = int.Parse(curXPInputField.text);
        chData.maxXP = int.Parse(maxXPInputField.text);
        chData.curHit = int.Parse(curHitInputField.text);
        chData.maxHit = int.Parse(maxHitInputField.text);
        chData.armor = int.Parse(armorInputField.text);

        //Slider Values
        chData.walk = (int)walkSlider.value;
        chData.run = (int)runSlider.value;
        chData.jump = (int)jumpSlider.value;

        // Abilites
        chData.strength = int.Parse(strengthText.text) + rollMod;
        chData.dexterity = int.Parse(dexterityText.text) + rollMod;
        chData.constitution = int.Parse(constitutionText.text) + rollMod;
        chData.intelligence = int.Parse(intelligenceText.text) + rollMod;
        chData.wisdom = int.Parse(wisdomText.text) + rollMod;
        chData.charisma = int.Parse(charismaText.text) + rollMod;

        chData.race = dropdownToString(raceDropdown);
        chData.sClass = dropdownToString(classDropdown);
        chData.alignment = dropdownToString(alignmentDropdown);

        /*chData.output = displayAllCharacterData(outputText);*/

        chData.items = null;
        return chData;

    }

    public void SaveToJason()
    {

        CharacterData chData = newCharacter();
        

        string json = JsonUtility.ToJson(chData, true);
        outputField.text = parseJson(json);
        //File.WriteAllText(Application.dataPath + "/CharacterData.json", json);
        



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



    public void LoadFromJson()
    {
        string json = File.ReadAllText(Application.dataPath + "/CharacterData.json");
        CharacterData chData = JsonUtility.FromJson<CharacterData>(json);

        nameInputField.text = chData.name.ToString();
        curXPInputField.text = chData.curXP.ToString();
        maxXPInputField.text = chData.maxXP.ToString();

        curHitInputField.text = chData.curHit.ToString();
        maxHitInputField.text = chData.maxHit.ToString();
        armorInputField.text = chData.armor.ToString();

        //Sliders
        walkSlider.value = chData.walk;
        runSlider.value = chData.run;
        jumpSlider.value = chData.jump;

        //Abiilities
        strengthText.text = chData.strength.ToString();
        dexterityText.text = chData.dexterity.ToString();
        constitutionText.text = chData.constitution.ToString();
        intelligenceText.text = chData.intelligence.ToString();
        wisdomText.text = chData.wisdom.ToString();
        charismaText.text = chData.charisma.ToString();

        //DropDowns
        raceDropdown.value = raceDropdown.options.FindIndex(option => option.text == chData.race);
        classDropdown.value = classDropdown.options.FindIndex(option => option.text == chData.sClass);
        alignmentDropdown.value = alignmentDropdown.options.FindIndex(option => option.text == chData.alignment);

        

    }

    public string dropdownToString(TMPro.TMP_Dropdown dropdown)
    {
        // Returns the dropdown value within the option to text.
        return dropdown.options[dropdown.value].text;

    }

    public int getDropDownIndex(TMPro.TMP_Dropdown dropdown)
    {
        return dropdown.value;
    }


    public string displayAllCharacterData(TMPro.TMP_Text box)
    {
        string charToJson = File.ReadAllText(Application.dataPath + "/CharacterData.json");
        //Debug.Log(charToJson);
        

        return charToJson;
    }

    



}
