using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] PlanetInit planetInit;

    void Start()
    {

    }

    public void startGravity()
    {
        foreach (GameObject obj in planetInit.createdObjects)
        {
           obj.GetComponent<Attractor>().enabled = true;
            obj.GetComponent<Lauch>().enabled = true;
        }
    }
}
