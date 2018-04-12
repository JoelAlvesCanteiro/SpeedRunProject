using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour {

	#region Singleton
	public static Timer instance;
	void Awake()
	{
		instance = this;
	}
	#endregion
	public Text timerText;
	private float startTime;
	private bool ended = false;

	// Use this for initialization
	void Start () {
		startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if (ended)
			return;
		
		float t = Time.time - startTime;

		string minutes = ((int)t / 60).ToString();
		string seconds = (t % 60).ToString("f2");

		timerText.text = minutes + ":" + seconds;
	}
	public void End()
	{
		ended = true;
		timerText.color = Color.yellow;
	} 
}
