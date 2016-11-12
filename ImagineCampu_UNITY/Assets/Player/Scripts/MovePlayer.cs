using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class MovePlayer : MonoBehaviour {
	private Rigidbody2D body;
	private Vector2 targetPosition;
	private bool hasTarget=false;

	// Use this for initialization
	void Start () {
		body = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {

		Debug.Log (Vector2.Distance(targetPosition, transform.localPosition));
		if(hasTarget && Vector2.Distance(targetPosition, transform.localPosition) < .2f ) {
			body.velocity = Vector2.zero;
			transform.localPosition = targetPosition;
			hasTarget = false;
		}
	}

	public void moveTo(Vector2 position) {
		Vector2 oldPos = transform.localPosition;
		body.velocity = (position - oldPos);
		targetPosition = position;
		hasTarget = true;
	}
}
