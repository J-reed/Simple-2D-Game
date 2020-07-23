using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	public GUIStyle buttonstyle;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnGUI(){
		if(GUI.Button(new Rect(Screen.width * 0.05f, Screen.height * 0.45f, Screen.width * 0.4f, Screen.height * 0.15f),"Play Game",buttonstyle)){
			Floor_Move.Score = 0;
			Floor_Move.timer = 0;
			Player_Move.timer = 0;
			Powerup_charm.timer = 0;
			Powerup_CorrCharm.timer = 0;
			Application.LoadLevel(1);
		}
		/*if(GUI.Button(new Rect(Screen.width * 0.05f, Screen.height * 0.6f, Screen.width * 0.3f, Screen.height * 0.15f),"Options",buttonstyle)){
			Application.LoadLevel(3);
		}*/
		if(GUI.Button(new Rect(Screen.width * 0.05f, Screen.height * 0.75f, Screen.width * 0.2f, Screen.height * 0.15f),"Quit",buttonstyle)){
			Application.Quit();
		}
	}
}
