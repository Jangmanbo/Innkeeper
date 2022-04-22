using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State : ScriptableObject
{
    public string stateName;    // 상태 이름
    public string explanation;  // 설명 텍스트

    [Range(-1f, 0f)]
    public float commissionSuccessRate; // 의뢰 성공률 조정

    // 의뢰 성공률, 개인/파티 생존율 조정
    public virtual void AdjustRate()
    {
        // 의뢰 생존률 조정
    }

    public float GetCommissionSuccessRate()
    {
        return commissionSuccessRate;
    }
}
