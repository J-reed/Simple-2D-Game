using UnityEngine;
using System.Collections;

public class Floor_Move : MonoBehaviour {

	public Transform moving_platform;
	public float speed =-0.1f;
	public static float timer = 0f;
	public static int multiplier = 1;
	public static int Score = 0;
	public int sc_show;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x,(speed*timer));
		if (moving_platform.position.y <= -3.2) {
			moving_platform.position = new Vector3(Random.Range(-1.75f,0.45f),2.6f,0);
			Score=Score+(1*multiplier);
		}
		sc_show = Score;
	}
}
