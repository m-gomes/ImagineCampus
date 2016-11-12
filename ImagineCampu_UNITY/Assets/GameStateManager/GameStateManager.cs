using UnityEngine;
using System.Collections;

public class GameStateManager : MonoBehaviour {
	private static GameStateManager instance = null;

	public bool chosePark = false;


	public static GameStateManager Instance {
		get {
			if (instance == null) {
				instance = GameObject.Find ("Managers").GetComponentInChildren<GameStateManager>();
			}

			return instance;
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void playerChosePark(bool value) {
		chosePark = value;
	}

	public bool getChosePark() {
		return chosePark;
	}
}
