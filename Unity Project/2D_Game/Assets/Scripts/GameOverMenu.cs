using UnityEngine;
using System.Collections;

public class GameOverMenu : MonoBehaviour {

	public GUIStyle buttonstyle;
	public GUIStyle Nonbuttonstyle;
	public static int Final_Score = Floor_Move.Score;


		

	// Use this for initialization
	void Start () {
		Final_Score = Floor_Move.Score;
	}
	
	// Update is called once per frame
	void Update () {

	}
	
	void OnGUI(){

		GUI.Button (new Rect (Screen.width * 0.3f, Screen.height * 0.10f, Screen.width * 0.8f, Screen.height * 0.063f), "Score: "+Final_Score, Nonbuttonstyle);

		if(GUI.Button(new Rect(Screen.width * 0.75f, Screen.height * 0.60f, Screen.width * 0.2f, Screen.height * 0.075f),"Retry",buttonstyle)){
			Floor_Move.Score = 0;
			Floor_Move.timer = 0;
			Player_Move.timer = 0;
			Powerup_charm.timer = 0;
			Powerup_CorrCharm.timer = 0;

			Application.LoadLevel(1);
		}
		if(GUI.Button(new Rect(Screen.width * 0.55f, Screen.height * 0.70f, Screen.width * 0.4f, Screen.height * 0.075f),"Main Menu",buttonstyle)){
			Application.LoadLevel(0);
		}
	}
}
