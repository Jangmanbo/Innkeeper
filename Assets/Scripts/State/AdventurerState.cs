using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Normal", menuName = "State/Adventurer/Normal")]
// ���谡 ü�� ����
public class AdventurerState : State
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
    [Range(-1f, 0f)]
    public float personalServivalRate; // ���� ������ ����
    [Range(-1f, 0f)]
    public float partyServivalRate; // ��Ƽ ������ ����

    // �Ƿ� ������, ����/��Ƽ ������ ����
    public override void AdjustRate()
    {
        // �Ƿ� ������ ����
        // ���� ������ ����
        // ��Ƽ ������ ����
    }

    public float GetPersonalServivalRate()
    {
        return personalServivalRate;
    }

    public float GetPartyServivalRate()
    {
        return partyServivalRate;
    }
}
