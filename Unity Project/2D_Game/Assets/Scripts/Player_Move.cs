using UnityEngine;
using System.Collections;

public class Player_Move : MonoBehaviour {

	public float speed =0.1f;
	public static float timer = 0f;
	public Transform Charm_object;
	public Transform Charm_Corr_object;
	public Transform Multi_up_object;
	public Transform Muilti_down_object;

	bool touchingevil = false;
	bool touchingcharm = false;
	bool touchingcorr_charm = false;
	bool touchingMulti_up = false;
	bool touchingMulti_down = false;

	public LayerMask platform;
	public LayerMask charm;
	public LayerMask Corr_charm;
	public LayerMask Multi_up;
	public LayerMask Multi_down;

	public Transform Tl;
	public Transform Tr;

	void FixedUpdate () {
		touchingevil = Physics2D.OverlapArea(Tl.position, Tr.position, platform);
		touchingcharm =Physics2D.OverlapArea(Tl.position, Tr.position, charm);
		touchingcorr_charm =Physics2D.OverlapArea(Tl.position, Tr.position, Corr_charm);
		touchingMulti_up =Physics2D.OverlapArea(Tl.position, Tr.position, Multi_up);
		touchingMulti_down =Physics2D.OverlapArea(Tl.position, Tr.position, Multi_down);

		if (touchingevil) {
			die();
		}
		if (touchingcharm) {
			if((timer-5>0)){
				timer=timer-5;
			}
			else{
				timer=0;
			}
			if(Floor_Move.timer-5>0){
				Floor_Move.timer=Floor_Move.timer-5;
			}
			else{
				Floor_Move.timer=0;
			}
			if((Powerup_charm.timer-5>0)){
				Powerup_charm.timer=Powerup_charm.timer-5;
			}
			else{
				Powerup_charm.timer=0;
			}
			if((Powerup_CorrCharm.timer-5>0)){
				Powerup_CorrCharm.timer=Powerup_CorrCharm.timer-5;
			}
			else{
				Powerup_CorrCharm.timer=0;
			}
			Charm_object.renderer.enabled = false;
			Charm_object.collider2D.enabled = false;

		}
		if (touchingcorr_charm) {
			if(Floor_Move.timer-10>0){
				Floor_Move.timer=Floor_Move.timer-10;
			}
			else{
				Floor_Move.timer=0;
			}

			if((Powerup_CorrCharm.timer-10>0)){
				Powerup_CorrCharm.timer=Powerup_CorrCharm.timer-10;
			}
			else{
				Powerup_CorrCharm.timer=0;
			}

			if((Powerup_charm.timer-10>0)){
				Powerup_charm.timer=Powerup_charm.timer-10;
			}
			else{
				Powerup_charm.timer=0;
			}
			Charm_Corr_object.renderer.enabled = false;
			Charm_Corr_object.collider2D.enabled = false;
		}
		if (touchingMulti_up) {
			Floor_Move.multiplier=Floor_Move.multiplier+1;
			Multi_up_object.renderer.enabled = false;
			Multi_up_object.collider2D.enabled = false;
		}
		if (touchingMulti_down) {
			if((Floor_Move.multiplier%2)==0){
				Floor_Move.multiplier=Floor_Move.multiplier/2;

			}
			else{
				Floor_Move.multiplier=(Floor_Move.multiplier+1)/2;
			}
			Muilti_down_object.renderer.enabled = false;
			Muilti_down_object.collider2D.enabled = false;
		}
	}


	// Update is called once per frame
	void Update () {

		timer += Time.deltaTime/2;

		float Direction = Input.GetAxis ("Horizontal");

		rigidbody2D.velocity = new Vector2 (Direction * (speed*timer), rigidbody2D.velocity.y);


	}
	void die(){
		Application.LoadLevel (2);
	}


}
