using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGameObject : MonoBehaviour
{
    // the Equip prefab - required for instantiation
    public GameObject equipPrefab;
    public Vector3 position;

    public void CreateObject()
    {
        // a prefab is need to perform the instantiation
        if (equipPrefab != null)
        {
            Instantiate(equipPrefab, position, Quaternion.identity); //Spawn gameobject from given position
        }
    }
}
