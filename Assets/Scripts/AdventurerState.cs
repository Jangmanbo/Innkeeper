using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ���谡 ü�� ����
public class AdventurerState : ScriptableObject
{
    public enum StateType
    {
        Hunger,     // ���
        Bleeding,   // ����
        Poisoning,  // �ߵ�
        Tired,      // �ǰ�
        Grief,      // ���
        Injury,     // �λ�
        Illness,    // ����
        ETC,        // ��Ÿ
    }

    public StateType stateType; // ���� �迭
    public string stateName;    // ���� �̸�
    public string explanation;  // ���� �ؽ�Ʈ
    [Range(0f, 1f)]
    public float decreaseCommissionSuccessRate; // �Ƿ� ������ ������

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
