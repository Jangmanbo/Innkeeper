using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Madness", menuName = "State/Adventurer/Madness")]
public class MadnessState : AdventurerState
{
    // 의뢰 성공률 조정 및 부가 효과
    public override void AdjustRate()
    {
        // 의뢰 생존률 조정
        // 부상,출혈,우울 중 랜덤 부여 (파티)
    }
}
