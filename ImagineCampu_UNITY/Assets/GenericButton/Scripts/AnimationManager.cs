using UnityEngine;
using System.Collections;
using Fungus;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Collider2D))]
public class AnimationManager : MonoBehaviour {
	[SerializeField] private Flowchart flowchart;
	[SerializeField] private string blockName;
	[SerializeField] private AudioSource clickSound,selectSound;
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
				clickSound.Play ();
			}
		}
	}

	void OnMouseEnter() {
		anim.SetBool ("mouseOver",true);
		mouseOver = true;
		selectSound.Play ();
	}

	void OnMouseExit() {
		anim.SetBool ("mouseOver",false);
		mouseOver = false;
	}
}
