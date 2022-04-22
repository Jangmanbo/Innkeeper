using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class Speices : ScriptableObject
{
    public enum SpeciesType
    {
        Human,
        Dwarf,
        Elf,
        Beastface,
        Oak,
        Goblin,
        Reve,
    }

    public enum MoneyType
    {
        Gold,
        ETC2,
        ETC3,
        ETC4,
    }

    public SpeciesType speciesType;
    public MoneyType moneyType;
}
