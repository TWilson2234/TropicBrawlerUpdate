using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;


public class CharacterHealth : MonoBehaviour
{
	public int startingHealth = 100;
	public int healthPoints;
	public Slider healthSlider;
	public Image damageImage;
	public AudioClip deathClip;
	public float flashSpeed = 5f;
	public Color flashColour = new Color(1f, 0f, 0f, 0.1f);

	public CameraController camCon;
	public CharacterMovement charMove;
	private Animator charAnim;

	AudioSource playerAudio;
	bool isDead;
	bool damaged;


	void Start ()
	{
		charAnim = GetComponent <Animator> ();
		playerAudio = GetComponent <AudioSource> ();
		charMove = GetComponent <CharacterMovement> ();
		camCon = this.GetComponentInChildren <CameraController> ();
		healthPoints = startingHealth;
	}


	void Update ()
	{
		if(damaged)
		{
			damageImage.color = flashColour;
		}
		else
		{
			damageImage.color = Color.Lerp (damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
		}
		damaged = false;
	}


	public void TakeDamage (int amount)
	{
		damaged = true;

		healthPoints -= amount;

		healthSlider.value = healthPoints;

		// playerAudio.Play ();

		/* if(currentHealth <= 0 && !isDead)
		{
			Death ();
		} */
	}


	/* void Death ()
	{
		isDead = true;

		playerShooting.DisableEffects ();

		anim.SetTrigger ("Die");

		playerAudio.clip = deathClip;
		playerAudio.Play ();

		playerMovement.enabled = false;
		playerShooting.enabled = false;
	} 


	public void RestartLevel ()
	{
		SceneManager.LoadScene (0);
	} */
}
