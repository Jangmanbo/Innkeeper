using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class Profession : ScriptableObject
{
    public enum ProfessionType
    {
        Warrior,    // ����
        Thief,      // ����
        Wizard,     // ������
        Troubadour, // ��������
        Priest,     // ����
        Astrologist,// ��������
        Hunter,     // ��ɲ�
    }

    public ProfessionType professionType;
}
