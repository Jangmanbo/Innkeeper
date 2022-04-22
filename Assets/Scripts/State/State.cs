using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State : ScriptableObject
{
    public string stateName;    // ���� �̸�
    public string explanation;  // ���� �ؽ�Ʈ

    [Range(-1f, 0f)]
    public float commissionSuccessRate; // �Ƿ� ������ ����

    // �Ƿ� ������, ����/��Ƽ ������ ����
    public virtual void AdjustRate()
    {
        // �Ƿ� ������ ����
    }

    public float GetCommissionSuccessRate()
    {
        return commissionSuccessRate;
    }
}
