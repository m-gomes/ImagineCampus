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
	private bool firstSpot = false;
	private bool secondSpot1 = false;
	private bool secondSpot2 = false;

	// Use this for initialization
	void Start () {
		body = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (GameStateManager.Instance.chosePark + " " + secondSpot1 + " (" + (transform.localPosition.x > 20.22f) + " " + (transform.localPosition.y > -0.48) + ")");
		if (!firstSpot && transform.localPosition.x > 15f) {
			body.velocity = Vector2.zero;

			leftWheel.SetBool ("moving",false);
			rightWheel.SetBool ("moving",false);

			choiceCanvas.gameObject.SetActive (true);

			firstSpot = true;
		
		} else if(GameStateManager.Instance.chosePark && !secondSpot1 && (transform.localPosition.x > 20.22f ) ) {
			body.velocity = Vector2.zero;
			transform.localPosition = new Vector3 (20.22f, -0.48f, 0f);

			leftWheel.SetBool ("moving",false);
			rightWheel.SetBool ("moving",false);

			choiceCanvas.gameObject.SetActive (true);

			secondSpot1 = true;
		
		} else if(!GameStateManager.Instance.chosePark && !secondSpot2 && (transform.localPosition.x > 30f)) {
			//body.velocity = Vector2.zero;

			leftWheel.SetBool ("moving",false);
			rightWheel.SetBool ("moving",false);

			choiceCanvas.gameObject.SetActive (true);

			secondSpot2 = true;
		}
			
	}

	public void setSpeed (float speed) {
		body.velocity = new Vector2 (speed, 0f);

		leftWheel.SetBool ("moving",true);
		rightWheel.SetBool ("moving",true);
	}

	public void setSpeed (float speedX, float speedY) {
		body.velocity = new Vector2 (speedX, speedY);

		leftWheel.SetBool ("moving",true);
		rightWheel.SetBool ("moving",true);
	}
}
