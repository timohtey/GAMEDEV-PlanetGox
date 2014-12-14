using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

	private float timeLeft;
	private int mins;
	private int secs;
	private int fractions;

	// Use this for initialization
	void Start () {
		timeLeft = 90.0f;
	}
	
	// Update is called once per frame
	void Update () {
		timeLeft -= Time.deltaTime;
		mins = (int) timeLeft / 60;
		secs = (int)timeLeft % 60;
		fractions = (int) (timeLeft * 100) % 100;
		this.guiText.text = string.Format("{0:00}:{1:00}:{2:00}", mins, secs, fractions);
		if(timeLeft < 0)
		{
			Application.LoadLevel(2);
		}
	}
}
