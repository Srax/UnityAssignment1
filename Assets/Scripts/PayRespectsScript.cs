using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PayRespectsScript : MonoBehaviour
{

    public string key = "f";

    void Update()
    {
        if(Input.GetKeyDown(key)) {
            Debug.Log("Respects");
        }
    }
}
