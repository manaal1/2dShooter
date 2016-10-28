using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour {
	public bool moveleft;
	public bool moveright;
	public bool jump;
	public Rigidbody2D rb;
	public float movespeed;
	public float jumpheight;
	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatIsGround;
	private bool onGround;
	public Sprite four;
	public Animator animation;
	public GameObject player;
	public GameObject carriedObject;
	public GameObject BULLET;
	public GameObject SpawnPos;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		SoundEffectsHelper.Instance.MakeEnemyShotSound();
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetKey(KeyCode.A))
		{
			rb.velocity = new Vector2 (-movespeed ,rb.velocity.y );
			animation.enabled = true;
			player.transform.GetChild(1).gameObject.GetComponent<AudioSource>().Play();
		}
		if (Input.GetKeyUp (KeyCode.A)) {
			animation.enabled = false;
			player.GetComponent<SpriteRenderer> ().sprite = four;
			player.transform.GetChild(1).gameObject.GetComponent<AudioSource>().Pause();
		}
		if (Input.GetKeyUp (KeyCode.D)) {
			animation.enabled = false;
			player.GetComponent<SpriteRenderer> ().sprite = four;
			player.transform.GetChild(1).gameObject.GetComponent<AudioSource>().Pause();
		}
		if (Input.GetKeyUp (KeyCode.W)) {
			animation.enabled = false;
			player.GetComponent<SpriteRenderer> ().sprite = four;
			player.transform.GetChild(1).gameObject.GetComponent<AudioSource>().Pause();
		}
		if(Input.GetKey(KeyCode.D))
		{
			rb.velocity = new Vector2 (movespeed ,rb.velocity.y );
			animation.enabled = true;
			player.transform.GetChild(1).gameObject.GetComponent<AudioSource>().Play();
		}
		if (moveright)
		{
			rb.velocity = new Vector2(movespeed, rb.velocity.y);
		}
		if (moveleft)
		{
			rb.velocity = new Vector2(-movespeed, rb.velocity.y);
		}
		if (Input.GetKey(KeyCode.W))
		{
			rb.velocity = new Vector2(rb.velocity.x, jumpheight);
			animation.enabled = true;
			player.transform.GetChild(1).gameObject.GetComponent<AudioSource>().Pause();
		}

		if (jump)
		{
			rb.velocity = new Vector2(rb.velocity.x, jumpheight);
			jump = false;

			SoundEffectsHelper.Instance.MakeEnemyShotSound();
		}
		if (Input.GetKeyDown (KeyCode.S)) {
			carriedObject = Instantiate (BULLET, SpawnPos.transform.position, SpawnPos.transform.rotation) as GameObject;
			carriedObject.gameObject.GetComponent<Rigidbody> ().isKinematic = false;
			carriedObject.gameObject.GetComponent<Rigidbody> ().useGravity = true;
			carriedObject.gameObject.GetComponent<Rigidbody> ().AddForce (SpawnPos.transform.right * 1000);

			Destroy (carriedObject, 1f);
		}
		// ...

		//  - Shooting
		bool shoot = Input.GetButtonDown("Fire1");
		shoot |= Input.GetButtonDown("Fire2");
		// Careful: For Mac users, ctrl + arrow is a bad idea

		if (shoot)
		{
			WeaponScript weapon = GetComponent<WeaponScript>();
			if (weapon != null)
			{
				// false because the player is not an enemy
				weapon.Attack(false);
				SoundEffectsHelper.Instance.MakeEnemyShotSound();
			}
		}

		// ...

		}
	void FixedUpdate()
	{
		onGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
	}
}
