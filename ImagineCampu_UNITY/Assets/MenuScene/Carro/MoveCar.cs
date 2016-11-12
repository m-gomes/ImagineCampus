using UnityEngine;
using System.Collections;
using Fungus;

[RequireComponent(typeof(Rigidbody2D))]
public class MoveCar : MonoBehaviour {
	private Rigidbody2D body;
	[SerializeField] private float speed = 5f;
	[SerializeField] private Animator leftWheel;
	[SerializeField] private Animator rightWheel;
	[SerializeField] private GameObject choiceCanvas;

	// Use this for initialization
	void Start () {
		body = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.localPosition.x > 15f) {
			body.velocity = Vector2.zero;

			leftWheel.SetBool ("moving",false);
			rightWheel.SetBool ("moving",false);

			choiceCanvas.gameObject.SetActive (true);
		}
			
	}

	public void setSpeed (float speed) {
		body.velocity = new Vector2 (speed, 0f);

		leftWheel.SetBool ("moving",true);
		rightWheel.SetBool ("moving",true);
	}
}
