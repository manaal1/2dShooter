using UnityEngine;
using System.Collections;

public class Touch : MonoBehaviour {

	private Controls player;
	public Sprite four;
	public Animator animation;
	void Start()
	{
		player = FindObjectOfType<Controls>();
	}

	public void LeftArrow()
	{
		player.moveright = false;
		player.moveleft = true;
		animation.enabled = true;
	}
	public void RightArrow()
	{
		player.moveright = true;
		player.moveleft = false;
		animation.enabled = true;
	}
	public void ReleaseLeftArrow()
	{
		player.moveleft = false;
		animation.enabled = false;
		player.GetComponent<SpriteRenderer> ().sprite = four;
	}
	public void ReleaseRightArrow()
	{
		player.moveright = false;
		animation.enabled = false;
		player.GetComponent<SpriteRenderer> ().sprite = four;
	}
	public void Jump()
	{
		player.jump = true;
		animation.enabled = true;
	}
	public void JumpRelease()
	{
		player.jump = false;
		animation.enabled = false;
		player.GetComponent<SpriteRenderer> ().sprite = four;

	}
}
