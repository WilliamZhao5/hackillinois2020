using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderSelection : MonoBehaviour

{
    // Start is called before the first frame update
    public float mass;
    public Rigidbody rb;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MassChanged(float value)
    {
        this.mass = value;
        rb = GetComponent<Rigidbody>();
        rb.mass = mass;
    }



}
