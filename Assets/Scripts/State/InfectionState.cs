using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Infection", menuName = "State/Adventurer/Infection")]
public class InfectionState : AdventurerState
{
    // 의뢰 성공률 조정 및 부가 효과
    public override void AdjustRate()
    {
        // 의뢰 생존률 조정
        // 중독, 질병 중 랜덤 부여 (개인)
    }
}
