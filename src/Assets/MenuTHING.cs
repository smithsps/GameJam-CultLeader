using UnityEngine;
using System.Collections;

public class MenuTHING : MonoBehaviour {

	public Texture menuBG;
	public string titleText;
	public Rect titlePos;
	public GUIStyle titleStyle;

	public string Play;
	public Rect PlayPos;
	public string Exit;
	public Rect ExitPos;
	public GUIStyle buttonStyle;

	void OnGUI () {
		GUI.DrawTexture(new Rect(0,0,1600,900), menuBG);
		GUI.Label(titlePos, titleText ,titleStyle);

		GUI.Button(PlayPos, Play, buttonStyle);
		GUI.Button(ExitPos, Exit, buttonStyle);
	}
}
