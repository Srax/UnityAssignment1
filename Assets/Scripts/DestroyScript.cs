using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScript : MonoBehaviour
{
    private float destroyDelay;
    public float maxRandom, minRandom;
    public GameObject objectToDestory; //the gameobject


    void Start()
    {
        destroyDelay = Random.Range(maxRandom, minRandom); //Make random spawn delay between two given seconds
        print(destroyDelay);
    }
      


    void Update()
    {
        Object.Destroy(objectToDestory, destroyDelay); //destroy gameobject after delay
    }
}
