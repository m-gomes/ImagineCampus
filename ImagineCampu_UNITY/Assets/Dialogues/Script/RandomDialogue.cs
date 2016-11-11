using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RandomDialogue : MonoBehaviour {
	[SerializeField] private int numberOfDialogues = 4;
	private List<int> idPool = new List<int> ();
	private List<int> alreadyChoosen = new List<int> ();


	// Use this for initialization
	void Start () {
		for (int i = 0; i < numberOfDialogues; i++) {
			idPool.Add (i);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public int getRandomDialogueLocation() {
		int index = Random.Range (0, idPool.Count);

		int returnValue = idPool[index];

		idPool.RemoveAt (index);
		alreadyChoosen.Add (returnValue);

		if(idPool.Count == 0) {
			resetPool();
		}

		return returnValue;
	}

	private void resetPool() {
		foreach(int id in alreadyChoosen) {
			idPool.Add (id);
		}

		alreadyChoosen.Clear ();
	}
}
