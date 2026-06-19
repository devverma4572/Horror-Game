using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    
public class Box : MonoBehaviour
{
    public GameObject boxHolder;
    void OnTriggerEnter(Collider other)
    {
        boxHolder.SetActive(false);
    }
}
