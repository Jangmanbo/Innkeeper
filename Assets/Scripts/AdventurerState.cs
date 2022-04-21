using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 모험가 체력 상태
public class AdventurerState : ScriptableObject
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
    public string stateName;    // 상태 이름
    public string explanation;  // 설명 텍스트
    [Range(0f, 1f)]
    public float decreaseCommissionSuccessRate; // 의뢰 성공률 감소율

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
