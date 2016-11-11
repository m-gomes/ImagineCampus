using UnityEngine;
using System.Collections;
using Fungus;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Collider2D))]
public class AnimationManager : MonoBehaviour {
	[SerializeField] private Flowchart flowchart;
	[SerializeField] private string blockName;
	private Animator anim;
	private bool mouseOver = false;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			if (mouseOver) {
				flowchart.ExecuteBlock (blockName);
			}
		}
	}

	void OnMouseEnter() {
		anim.SetBool ("mouseOver",true);
		mouseOver = true;
	}

	void OnMouseExit() {
		anim.SetBool ("mouseOver",false);
		mouseOver = false;
	}
}
