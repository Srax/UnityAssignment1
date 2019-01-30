using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugOnLoad : MonoBehaviour
{
    public string debugText;
    void Start()
    {
        Debug.Log(debugText);
    }
}
