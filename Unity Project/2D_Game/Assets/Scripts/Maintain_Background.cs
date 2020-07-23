using UnityEngine;
using System.Collections;

public class Maintain_Background : MonoBehaviour {

	public Transform gameobject;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (gameobject.position.z > -0.1) {
			gameobject.position = new Vector3 (gameobject.position.x,gameobject.position.y, -0.1f);
		}
	}
}
