using UnityEngine;
using System.Collections;

public class GameStateManager : MonoBehaviour {
	public bool chosePark = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void playerChosePark(bool value) {
		chosePark = value;
	}
}
