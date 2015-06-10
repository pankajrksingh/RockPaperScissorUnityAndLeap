using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class StartPage_Unity5 : MonoBehaviour 
{
	public GUISkin m_mainSkin = new GUISkin();

	protected LeapRecorder recorder_ = new LeapRecorder();

	public Rect OptionsRect = new Rect();
	public Rect NewGameRect = new Rect();
	public Rect DemoRect = new Rect();
	public Rect LeaderBoardRect = new Rect();
	public Rect QuitRect = new Rect();

	public nextScene_Unity5 m_nextSceneObj = new nextScene_Unity5();


	// Use this for initialization
	void Start () 
	{
		//m_nextSceneObj.m_WinnerNameCheck = true;
		m_nextSceneObj.m_WinnerNameCheck = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
		if(m_nextSceneObj.m_WinnerNameCheck)
		{
			m_nextSceneObj.m_sWinnerString = m_nextSceneObj.m_sWinnerText + m_nextSceneObj.m_sWinnerName;
		}

		else
		{
			m_nextSceneObj.m_sWinnerString = m_nextSceneObj.m_MatchTieString;
		}
	}

	// all ur buttons and other stuff comes here..
	void OnGUI()
	{
		GUI.skin = m_mainSkin;

		GUI.BeginGroup (OptionsRect, "", (GUIStyle)"label");

		if (GUI.Button (NewGameRect, "NEW GAME", (GUIStyle)"Buttons")) 
		{
			Application.LoadLevel("HandSandBox");
		}

		if (GUI.Button (DemoRect, "INSTRUCTIONS", (GUIStyle)"Buttons")) 
		{
			Application.LoadLevel("DemoScene");
		}

		if (GUI.Button (LeaderBoardRect, "LEADERBOARD", (GUIStyle)"Buttons")) 
		{
			Application.LoadLevel("leaderBoard");
		}

		if (GUI.Button (QuitRect, "QUIT", (GUIStyle)"Buttons")) 
		{
			Application.Quit();
		}

		GUI.EndGroup ();
	
	}
}