using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
	private int count;
	private AudioSource PickUpItem;
	public GUIText found;

	void Start () {
		count = 0;
		PickUpItem = this.GetComponent<AudioSource>();
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Notebook" || other.gameObject.tag == "Bottle" || other.gameObject.tag == "USB" || other.gameObject.tag == "Umbrella" || other.gameObject.tag == "Bag") {
			other.gameObject.SetActive(false);
			count++;
			found.text = count + " of 5 OBJECTS FOUND";
			PickUpItem.Play();
			if(count == 5)
				Application.LoadLevel(3);
		}
	}                                                     

}
