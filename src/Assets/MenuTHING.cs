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

		if(GUI.Button(PlayPos, Play, buttonStyle)) {
			Application.LoadLevel("Transition");
		}
		//So if not web player show close button.
		if(!Application.isWebPlayer) {
			if(GUI.Button(ExitPos, Exit, buttonStyle)) {
				Application.Quit();
			}
		}
	}
}
