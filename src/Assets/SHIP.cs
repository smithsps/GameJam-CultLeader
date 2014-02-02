using UnityEngine;
using System.Collections;

public class SHIP : MonoBehaviour {

	public Texture ship;
	public Texture PERSON;
	public Texture BG;
	public GUIStyle mstyle;


	void OnGUI() {
		GUI.DrawTexture(new Rect(0,0,1600,900),BG);
		GUI.DrawTexture(new Rect(300,0,1280,720), ship);

		//SHIPS STATS
		Rect r = new Rect(50,50,200,50);

		mstyle.fontSize = 75;
		GUI.Label(new Rect(50,50,200,50),"You Win!", mstyle);
		mstyle.fontSize = 25;
		GUI.Label(new Rect(60,150,200,50), "Press anywhere to continue.", mstyle);

		GUI.DrawTexture(new Rect(875, 300,128,128), PERSON);

		if(GUI.Button(new Rect(0,0,1600,900), "", mstyle)){
			Application.LoadLevel("End");
		}

	}
	
}
