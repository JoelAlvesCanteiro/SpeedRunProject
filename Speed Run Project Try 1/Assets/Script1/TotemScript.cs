using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotemScript : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		if(other.tag == "Player"){
			PlayerTotem.instance.totemPoint++;
			Debug.LogWarning (PlayerTotem.instance.totemPoint);
			Destroy(gameObject);

		}
	}
}
