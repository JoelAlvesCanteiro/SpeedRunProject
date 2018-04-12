using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {
	public Text finalTime;
	public Text finalTotem;
	public GameManager gameManager;

	void OnTriggerEnter ()
	{
		finalTime.text = " Votre temps final est " + Timer.instance.timerText.text;
		finalTotem.text = "Vous avez récupéré " + "" + PlayerTotem.instance.totemPoint + "" + " totems";
		gameManager.CompleteLevel ();
	}
}
