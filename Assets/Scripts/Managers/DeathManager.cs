using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathManager : MonoBehaviour {

	public int startingHealth = 3;
	public int currentHealth;

	bool isDead;
	bool damaged;


	void Awake (){
		currentHealth = startingHealth;
	}
		
	void Update ()
	{
		if (damaged) {
			
		}
		damaged = false;
	}

	public void TakeDamage (int amount)
		{
			damaged = true;

			currentHealth -= 1;

			if(currentHealth <= 0 && !isDead)
			{
				Death ();
			}
		}


		void Death ()
		{
			isDead = true;
			Time.timeScale = 0;
		}
	}
