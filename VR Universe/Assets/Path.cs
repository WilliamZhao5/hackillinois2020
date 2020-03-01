using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour
{
	// Transforms to act as start and end markers for the journey.
	public Transform Cube;
	public Transform End;

	// Movement speed in units per second.
	public float speed = 1.0F;

	// Time when the movement started.
	private float startTime;

	// Total distance between the markers.
	private float journeyLength;

	void Start()
	{
		// Keep a note of the time the movement started.
		startTime = Time.time;

		// Calculate the journey length.
		journeyLength = Vector3.Distance(Cube.position, End.position);
	}

	// Move to the target end position.
	void Update()
	{
		// Distance moved equals elapsed time times speed..
		float distCovered = (Time.time - startTime) * speed;

		// Fraction of journey completed equals current distance divided by total distance.
		float fractionOfJourney = distCovered / journeyLength;

		// Set our position as a fraction of the distance between the markers.
		transform.position = Vector3.Lerp(Cube.position, End.position, fractionOfJourney);
	}
}