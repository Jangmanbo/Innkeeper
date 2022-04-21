using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Trait : ScriptableObject
{
    public string traitName;    // 트레잇 이름
    public string explanation;  // 설명 텍스트

    public abstract void InvokeTrait();
}
