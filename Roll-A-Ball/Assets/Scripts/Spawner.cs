using UnityEngine;
using System.Collections;


public class Spawner : MonoBehaviour {

	public float[] Xspawnpoint;
	public float[] Yspawnpoint;
	public float[] Zspawnpoint;
	private int number;
	private Vector3 spawnpoint;
	// Use this for initialization
	void Start () {
		Random.seed = (int) System.DateTime.Now.Ticks;
		number = (int)(Random.Range(0, 5));
		spawnpoint = new Vector3 (Xspawnpoint [number], Yspawnpoint [number], Zspawnpoint [number]);
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = spawnpoint;
	}
}
