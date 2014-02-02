using UnityEngine;
using System.Collections;

public class Transition : MonoBehaviour {

	public string monolog;
	public Rect textRect;
	public GUIStyle mstyle;

	private GUIStyle clear;

	public Texture BG;



	void OnGUI() {
		GUI.DrawTexture(new Rect(0,0,1600,900), BG);
		GUI.TextArea(textRect, curText, mstyle);

		GUI.Label(new Rect(400,600, 50, 50), "Click anywhere to continue.", mstyle);

		if(GUI.Button(new Rect(0,0,1600,900), "", mstyle)){
			Application.LoadLevel("Game");
		}
	}

	private int timer = 0;
	private string curText = "";
	private int charCount = 0;

	void Update() {
		int mod = 3;

		if((timer % mod == 0) && charCount < monolog.Length) {
			charCount++;
			curText = monolog.Substring(0, charCount);
		}
		timer++;
	}
}
