using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Normal", menuName = "State/Adventurer/Normal")]
// 모험가 체력 상태
public class AdventurerState : State
{
    public enum StateType
    {
        Hunger,     // 허기
        Bleeding,   // 출혈
        Poisoning,  // 중독
        Tired,      // 피곤
        Grief,      // 우울
        Injury,     // 부상
        Illness,    // 질병
        ETC,        // 기타
    }

    public StateType stateType; // 상태 계열
    [Range(-1f, 0f)]
    public float personalServivalRate; // 개인 생존율 조정
    [Range(-1f, 0f)]
    public float partyServivalRate; // 파티 생존율 조정

    // 의뢰 성공률, 개인/파티 생존율 조정
    public override void AdjustRate()
    {
        // 의뢰 생존률 조정
        // 개인 생존율 조정
        // 파티 생존율 조정
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
