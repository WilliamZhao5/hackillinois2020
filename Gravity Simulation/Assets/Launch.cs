using UnityEngine;

public class Launch : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cylinder;

    public Rigidbody asteroid;

    private Vector3 direction;

    void Start()
    {
        Launchat();
        asteroid.AddForce(direction);
    }

    void Launchat()
    {
        direction = cylinder.transform.position;

    }
}
