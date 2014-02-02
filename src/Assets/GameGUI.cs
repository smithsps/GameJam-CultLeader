using UnityEngine;
using System.Collections;

public class GameGUI : MonoBehaviour {

	public Texture BG;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnGUI () {
		//BG
		GUI.DrawTexture(new Rect(0,0,1600,900),BG);
	}
}
