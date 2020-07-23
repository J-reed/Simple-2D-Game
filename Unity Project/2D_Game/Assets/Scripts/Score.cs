using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
	public int PlayerScore = Floor_Move.Score;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		PlayerScore = Floor_Move.Score;


		guiText.text = ""+PlayerScore;

	}
}
