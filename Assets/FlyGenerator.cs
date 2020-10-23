using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyGenerator : MonoBehaviour
{
    public GameObject fly;
    void Start()
    {
        for(int i = 0; i<10; i++)
        { 
            // Instantiate Jars randomly
            Instantiate(fly, new Vector3(Random.Range(-10.0f, 10.0f),1,Random.Range(-10.0f,10.0f)), Quaternion.identity);
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
