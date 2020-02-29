using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attractor : MonoBehaviour
{
    public Rigidbody rb1;

    void FixedUpdate()
    {
        Attractor[] attractors = FindObjectsOfType<Attractor>();
        foreach (Attractor attractor in attractors)
        {
            if (attractor != this)
            Attract_planet(attractor);
        }
    }
    void Attract_planet(Attractor objtoAttract)
    {
        Rigidbody rbToAttract = objtoAttract.rb1;

        Vector3 direction = rb1.position - rbToAttract.position;
        float distance = direction.magnitude;

        float forceMagnitude = (rb1.mass * rbToAttract.mass) / Mathf.Pow(distance, 2);
        Vector3 force = direction.normalized * forceMagnitude;

        rbToAttract.AddForce(force);
    }
}
