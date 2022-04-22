using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Druck", menuName = "State/Adventurer/Druck")]
public class DruckState : AdventurerState
{
    // 의뢰 성공률 조정 및 부가 효과
    public override void AdjustRate()
    {
        // 의뢰 생존률 조정
        // 5% 확률로 취함 부여 (파티)
    }
}
