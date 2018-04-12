using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTotem : MonoBehaviour {

	#region Singleton
	public static PlayerTotem instance;
	public int totemPoint;
	void Awake()
	{
		instance = this;
	}
	#endregion
}
