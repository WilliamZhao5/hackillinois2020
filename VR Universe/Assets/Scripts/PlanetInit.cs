using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetInit : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] GameObject basicPlanetPrefab;
    [SerializeField] GameObject massSlider;
    [SerializeField] Transform parent;
    public List<GameObject> createdObjects;
    public float mass = 100;
    private Vector3 direction;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void initPlanet()
    {

        float xChange = 0.0f + Random.Range(-5, 5);
        float ychange = 5.55f + Random.Range(-5, 5);
        Vector3 position = new Vector3(xChange, 0.327f, ychange);
        GameObject planet = Instantiate(basicPlanetPrefab, position, Quaternion.identity, parent);
        createdObjects.Add(planet);

        Rigidbody rb = planet.GetComponent<Rigidbody>();
        rb.mass = mass;
        
    }

    public void onMassChanged(float value)
    {
        Debug.Log("mass changed in slider");
        mass = value;
    }



    void onVelocityChange(float value)
    {
        Lauch.velocity = value;
    }
}
