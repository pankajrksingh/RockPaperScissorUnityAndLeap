using UnityEngine;
using System.Collections;
[ExecuteInEditMode]

public class nextScene_Unity5 : MonoBehaviour {


	public static string RockString = "Rock";
	public static string PaperString = "Paper";
	public static string ScissorString = "Scissor";

	
	public Rect resumeRect = new Rect();
	public Rect QuitRect = new Rect();
	public Rect winRect = new Rect();
	public GUISkin m_nextSkin = new GUISkin();
	public float num=0.0f;
	public string m_sWinnerString = string.Empty;
	public string m_sWinnerText = string.Empty;
	public string m_sWinnerName = string.Empty;
	public string m_MatchTieString = string.Empty;
	public bool m_WinnerNameCheck = false;

	public Rect m_ResultBox = new Rect();
	public Rect m_NoHand = new Rect();

	// Use this for initialization
	void Start () {
		resumeRect.x = Screen.width / 2 - resumeRect.width / 2 - 25.0f;
		QuitRect.x = resumeRect.x + QuitRect.width;
		winRect.x = Screen.width / 2 - winRect.width / 2;
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnGUI()
	{
		GUI.skin = m_nextSkin;

		//Displaying Palyer Hand Output
		if (WinnerResult.PlayerHand == RockString && WinnerResult.ComputerHand == RockString) {
			GUI.Box(m_ResultBox,"",(GUIStyle)"rock-vs-rock");
		}
		else if (WinnerResult.PlayerHand == PaperString && WinnerResult.ComputerHand == PaperString) {
			GUI.Box(m_ResultBox,"",(GUIStyle)"paper-vs-paper");
		}
		else if (WinnerResult.PlayerHand == ScissorString && WinnerResult.ComputerHand == ScissorString) {
			GUI.Box(m_ResultBox,"",(GUIStyle)"scissor-vs-scissor");
		}
		else if (WinnerResult.PlayerHand == PaperString && WinnerResult.ComputerHand == RockString) {
			GUI.Box(m_ResultBox,"",(GUIStyle)"paper-vs-rock");
		}
		else if (WinnerResult.PlayerHand == PaperString && WinnerResult.ComputerHand == ScissorString) {
			GUI.Box(m_ResultBox,"",(GUIStyle)"paper-vs-scissors");
		}
		else if (WinnerResult.PlayerHand == RockString && WinnerResult.ComputerHand == PaperString) {
			GUI.Box(m_ResultBox,"",(GUIStyle)"rock-vs-paper");
		}
		else if (WinnerResult.PlayerHand == RockString && WinnerResult.ComputerHand == ScissorString) {
			GUI.Box(m_ResultBox,"",(GUIStyle)"rock-vs-scissors");
		}
		else if (WinnerResult.PlayerHand == ScissorString && WinnerResult.ComputerHand == PaperString) {
			GUI.Box(m_ResultBox,"",(GUIStyle)"scissor-vs-paper");
		}
		else if (WinnerResult.PlayerHand == ScissorString && WinnerResult.ComputerHand == RockString) {
			GUI.Box (m_ResultBox, "", (GUIStyle)"scissor-vs-rock");
		} 
		else {
			GUI.Label(winRect,WinnerResult.WinnerName,(GUIStyle)"label");
		}



		if(GUI.Button (QuitRect, "QUIT", (GUIStyle)"Buttons"))
		{
			Application.LoadLevel("StartScene");
		}

		if (GUI.Button (resumeRect, "RETRY", (GUIStyle)"Buttons")) {
			Application.LoadLevel("HandSandBox");
		}
	}

}


public static class WinnerResult
{
	public static string WinnerName = "";
	public static string PlayerHand = "";
	public static string ComputerHand = "";

}
