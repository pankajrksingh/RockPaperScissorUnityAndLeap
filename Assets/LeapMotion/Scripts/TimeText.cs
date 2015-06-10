using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class TimeText : MonoBehaviour {

	public GUISkin m_handSkin = new GUISkin();
	public string inputTimerString = "Start";
	//public HandController m_HandController = new HandController ();
	public Rect timerRect = new Rect();
	//float timeRemTemp = m_HandController.timeRemaining;


	// Use this for initialization
	void Start () {
	
		timerRect.x = Screen.width / 2 - timerRect.width / 2;
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void setTimerText(string inputString){
		//inputTimerString = inputString;
	}

	void OnGUI()
	{
		GUI.skin = m_handSkin;

		GUI.Label(timerRect, inputTimerString, (GUIStyle)"HandSkin");
	}
}
