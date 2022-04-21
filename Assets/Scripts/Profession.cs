using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class Profession : ScriptableObject
{
    public enum ProfessionType
    {
        Warrior,    // 전사
        Thief,      // 도적
        Wizard,     // 마법사
        Troubadour, // 음유시인
        Priest,     // 사제
        Astrologist,// 점성술사
        Hunter,     // 사냥꾼
    }

    public ProfessionType professionType;
}
