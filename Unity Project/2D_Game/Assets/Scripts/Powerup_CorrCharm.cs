using UnityEngine;
using System.Collections;

public class Powerup_CorrCharm : MonoBehaviour {
	
	public Transform powerup;
	public float speed =-0.1f;
	public static float timer = 0f;
	public int x=-10;
	public int nextvisible;
	bool once = true;

	void awake(){


	}
	void Start () {
		//powerup.position = new Vector3 (Random.Range (-1.2f, 1.5f), -4.0f, -0.1f);
		//renderer.enabled=false;
		//collider2D.enabled=false;

		
	}
	
	// Update is called once per frame
	void Update () {
		if ((x + nextvisible >= timer-0.05)&&(x + nextvisible <= timer+0.05)) {
			powerup.position = new Vector3 (Random.Range (-1.2f, 1.5f), 4.0f, -2f);
			renderer.enabled=true;
			collider2D.enabled=true;
			nextvisible=0;
		}
		timer += Time.deltaTime;
		if (once) {
			renderer.enabled=false;
			collider2D.enabled=false;
			if(timer>1){
				once =false;
			}
		}

		rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x,(speed*timer));
		
		if (powerup.position.y <= -4.2) {
			powerup.position = new Vector3 (Random.Range (-1.2f, 1.5f), 4.0f, -2f);
			
			if((renderer.enabled==false)&&(nextvisible==0)){
				hide ();
			}
			
			if(renderer.enabled==true){
				hide ();
			}
			
		}
	}
	public void hide(){
		renderer.enabled=false;
		collider2D.enabled=false;
		x = (int)timer;
		nextvisible = Random.Range(1,30);
		
	}

}
