using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lauch : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject cylinder;
    [SerializeField] Rigidbody asteroid;
    public GameObject theAsteroid;
    private Vector3 direction;
    static public float velocity = 0;
    
    void Start()
    {
        Launchat();
        asteroid.AddForce(direction * velocity);
    }
    void Launchat()
    {
        direction = cylinder.transform.position - theAsteroid.transform.position;
    }

}
