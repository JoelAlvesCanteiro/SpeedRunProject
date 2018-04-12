using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

	public GameManager gameManager;

	void CollisionEnter (Collision collisionInfo)
	{
		// We check if the object we collided with has a tag called "Temple"
		if(collisionInfo.collider.tag == "Temple")
		{
			FindObjectOfType<GameManager>().EndGame();

		}
			

	}
}
