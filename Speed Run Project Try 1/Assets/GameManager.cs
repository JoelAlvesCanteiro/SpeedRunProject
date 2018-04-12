using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	bool gameHasEnded = false;

	public GameObject completeLevelUI;

	public void CompleteLevel ()
	{
		completeLevelUI.SetActive (true);


	}
	public void EndGame ()
	{
		if (gameHasEnded == false) 
		{
			gameHasEnded = true;
			Debug.Log ("GAME OVER");
			Restart ();
		}
	}

	void Restart ()
	{
		SceneManager.LoadScene("menu");
	}
}
