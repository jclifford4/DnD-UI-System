using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class PlayerManager : MonoBehaviour
{


    [SerializeField] private string name, race, Class, alignment;

    [SerializeField] private float strength, dexterity, constitution, 
                                    intelligence, wisdom, charisma;

    [SerializeField] private int armor, walk, run, jump;

    [SerializeField] private int curXP, maxXP, curHit, maxHit;
    [SerializeField] private List<string> items;

    

    // Input Fields
    private TMP_InputField if_name, maxXPField, curXPField, 
                           curHitField, maxHitField, armorField;



    // Text Boxes
    private TMP_Text rollTotalText, rollTotalText1, rollTotalText2, rollTotalText3,
                     rollTotalText4, rollTotalText5;
   

    // Drop Downs
    private TMP_Dropdown rDrop, cDrop, aDrop;

    // Sliders
    private Slider walkSlider, runSlider, jumpSlider;
    
    // Start is called before the first frame update
    void Start()
    { 
        initUIReferences();
        setPlayerPlaceHodlerValues();

    }

    private void setPlayerPlaceHodlerValues()
    {
        name = race = Class = alignment = "Empty";
        
        curHit = maxHit = curXP = maxXP = armor = 0;
        walk = run = jump = 2;
        strength = dexterity = constitution = intelligence = wisdom = charisma = 18;


    }



    // Update is called once per frame
    void Update()
    {
        updateInputFields();
        updateDropDowns();
        updateSliders();
        updateTextBoxes();
        


    }
    private void updateDropDowns()
    {
        //Drop Downs
        race = dropdownToString(rDrop);
        Class = dropdownToString(cDrop);
        alignment = dropdownToString(aDrop);
    }

    private void updateSliders() 
    {
        walk = (int)walkSlider.value;
        run = (int)runSlider.value;
        jump = (int)jumpSlider.value;
    }
    private void updateTextBoxes() 
    {
        strength = float.Parse(rollTotalText.text);
        dexterity = float.Parse(rollTotalText1.text);
        constitution = float.Parse(rollTotalText2.text);
        intelligence = float.Parse(rollTotalText3.text);
        wisdom = float.Parse(rollTotalText4.text);
        charisma = float.Parse(rollTotalText5.text);
    }
    private void updateInputFields()
    {
        name = if_name.text;
        curXP = int.Parse(curXPField.text);
        maxXP = int.Parse(maxXPField.text);
        curHit = int.Parse(curHitField.text);
        maxHit = int.Parse(maxHitField.text);
        armor = int.Parse(armorField.text);
    }

    private void initUIReferences()
    {
        if_name = GameObject.Find("if_name").GetComponent<TMP_InputField>();

        //
        rollTotalText = GameObject.Find("rollTotalText").GetComponent<TMP_Text>();
        rollTotalText1 = GameObject.Find("rollTotalText1").GetComponent<TMP_Text>();
        rollTotalText2 = GameObject.Find("rollTotalText2").GetComponent<TMP_Text>();
        rollTotalText3 = GameObject.Find("rollTotalText3").GetComponent<TMP_Text>();
        rollTotalText4 = GameObject.Find("rollTotalText4").GetComponent<TMP_Text>();
        rollTotalText5 = GameObject.Find("rollTotalText5").GetComponent<TMP_Text>();

        // DropDowns
        rDrop = GameObject.Find("rDrop").GetComponent<TMP_Dropdown>();
        cDrop = GameObject.Find("cDrop").GetComponent<TMP_Dropdown>();
        aDrop = GameObject.Find("aDrop").GetComponent<TMP_Dropdown>();


        //Input Fields
        

        maxXPField = GameObject.Find("maxXP").GetComponent<TMP_InputField>();
        curXPField = GameObject.Find("curXP").GetComponent<TMP_InputField>();
        curHitField = GameObject.Find("curHit").GetComponent<TMP_InputField>();
        maxHitField = GameObject.Find("maxHit").GetComponent<TMP_InputField>();
        armorField = GameObject.Find("armorField").GetComponent<TMP_InputField>();


        //Sliders
        walkSlider = GameObject.Find("walkSlider").GetComponent<Slider>();
        runSlider = GameObject.Find("runSlider").GetComponent<Slider>();
        jumpSlider = GameObject.Find("jumpSlider").GetComponent<Slider>();

    }

    

    public int getDropDownIndex(TMPro.TMP_Dropdown dropdown)
    {
        return dropdown.value;
    }

    public string dropdownToString(TMPro.TMP_Dropdown dropdown)
    {
        // Returns the dropdown value within the option to text.
        return dropdown.options[dropdown.value].text;

    }

}
