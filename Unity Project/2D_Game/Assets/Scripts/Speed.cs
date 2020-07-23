using UnityEngine;
using System.Collections;

public class Speed : MonoBehaviour {
	public double PlayerSpeed = (Player_Move.timer) * 0.1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		PlayerSpeed = (Player_Move.timer)*0.1;
		guiText.text = "Speed="+((Mathf.Round(( (float)(PlayerSpeed*10)))/10));

	}
}
