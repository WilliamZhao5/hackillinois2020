using UnityEngine;

public class Launch : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cylinder;

    public Rigidbody asteroid;

    public GameObject theAsteroid;

    private Vector3 direction;

    void Start()
    {
        Launchat();
        asteroid.AddForce(direction * 100);
    }

    void Launchat()
    {
        direction = cylinder.transform.position - theAsteroid.transform.position;

    }
}
 