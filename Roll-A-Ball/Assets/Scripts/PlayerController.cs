using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
	private int count;

	void Start () {
		count = 0;
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "PickUp") {
			other.gameObject.SetActive(false);
			count++;
		}
	}                                                     

}
