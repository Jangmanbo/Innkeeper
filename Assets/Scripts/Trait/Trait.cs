using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Trait : ScriptableObject
{
    public string traitName;    // Ʈ���� �̸�
    public string explanation;  // ���� �ؽ�Ʈ

    public abstract void InvokeTrait();
}
