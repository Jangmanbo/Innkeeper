using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Fracture", menuName = "State/Adventurer/Fracture")]
public class FractureState : AdventurerState
{
    // 의뢰 성공률 조정 및 부가 효과
    public override void AdjustRate()
    {
        // 의뢰 생존률 조정
        // 출혈,부상,감염 중 랜덤 부여 (개인)
    }
}
