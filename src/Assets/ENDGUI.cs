using UnityEngine;
using System.Collections;

public class ENDGUI : MonoBehaviour {

	public Texture BG;
	public Texture SHIP;

	public GUIStyle style;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnGUI () {
		//BG
		GUI.DrawTexture(new Rect(0,0,1280,720),BG);
		GUI.DrawTexture(new Rect(425,325,160,90),SHIP);

		GUI.Label(new Rect(650, 650,500,100), "Credits: Simon, William, Ricky", style);
	}
}
