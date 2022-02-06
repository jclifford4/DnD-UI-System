using UnityEngine;
using System.Collections.Generic;

[System.Serializable]
public class CharacterData
{
    public string name;
    public string race, sClass, alignment;

    public float strength, dexterity, constitution, intelligence, wisdom, charisma;
    public int armor, walk, run, jump;

    public int curXP, maxXP, curHit, maxHit;
    public List<string> items;


    /*public CharacterData(Player player)
    {
        name = player.name;
        race = player.race;
        sClass = player.sClass;
        alignment = player.alignment;
        strength = player.strength;
        dexterity = player.dexterity;
        constitution = player.constitution;
        intelligence = player.intelligence;
        wisdom = player.wisdom;
        charisma = player.charisma;
        curXP = player.curXP;
        maxXP = player.maxXP;
        curHit = player.curHit;
        maxHit = player.maxHit;
        items = player.items;
    }*/









    /*public string output;*/


}
