using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HourMinutesManager : MonoBehaviour {
	[SerializeField] Text hour;
	[SerializeField] Text minutes;
	[SerializeField] float passMinuteTime = 1f; // in seconds
	private float lastMinutePassedTime = 0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time - lastMinutePassedTime > passMinuteTime) {
			advanceMinutes ();
			lastMinutePassedTime = Time.time;
		}
	}

	public void advanceMinutes () {
		if (minutes.text.ToLower ().CompareTo ("59") == 0) {
			minutes.text = "00";

			int newHours = int.Parse(hour.text);
			newHours++;

			if (newHours < 10) {
				hour.text = "0" + newHours.ToString ();
			} else {
				hour.text = newHours.ToString();
			}


		
		} else {
			int newMinutes = int.Parse(minutes.text);
			newMinutes++;

			if (newMinutes < 10) {
				minutes.text = "0" + newMinutes.ToString ();
			} else {
				minutes.text = newMinutes.ToString();
			}


		}
	}

	public void setHour(string hour) {
		this.hour.text = hour;
	}

	public void setMinutes(string minutes) {
		this.minutes.text = minutes;
	}
}
