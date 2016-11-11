using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Collider2D))]
public class AnimationManager : MonoBehaviour {
	private Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseEnter() {
		anim.SetBool ("mouseOver",true);
	}

	void OnMouseExit() {
		anim.SetBool ("mouseOver",false);
	}
}
