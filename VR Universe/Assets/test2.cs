using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Plant;

    void Start()
    {
        string namePlant = Plant.name;
     
        GameObject.Find(namePlant).GetComponent<Launch>().enabled = true;
    }
}
