using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DoorsManager : MonoBehaviour {
	[SerializeField] private Animator leftDoorAnim;
	[SerializeField] private Animator rightDoorAnim;
	[SerializeField] private float openInterval=1f;
	[SerializeField] private float closeInterval=3f;
	[SerializeField] private bool loopingOpenClose = false;
	private float lastChangeTime = 0f;
	private bool doorsOpened = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(loopingOpenClose) {
			if (Time.time - lastChangeTime > openInterval) {
				if(doorsOpened) {
					lastChangeTime = Time.time;
					closeDoors ();
				}
			}

			if(Time.time - lastChangeTime > closeInterval) {
				if(!doorsOpened) {
					lastChangeTime = Time.time;
					openDoors();
				}
			}
		}
				
	}

	public void openDoors() {
		leftDoorAnim.SetBool ("leftdooropened",true);
		rightDoorAnim.SetBool ("rightdooropened",true);
		doorsOpened = true;
	}

	public void closeDoors() {
		leftDoorAnim.SetBool ("leftdooropened",false);
		rightDoorAnim.SetBool ("rightdooropened",false);
		doorsOpened = false;
	}
}
