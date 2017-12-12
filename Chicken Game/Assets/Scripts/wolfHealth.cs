using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wolfHealth : MonoBehaviour {

public int currentHealth;
public int maxHealth = 3;
public int points;

void Start(){
	currentHealth = maxHealth;
}

	public void TakeDamage(int amount){
		currentHealth -= amount;
		if(currentHealth<=0){
			//Keep score at zero
			currentHealth=0;
			print("Wolf is Dead!");
			//Add points to score for killing wolf
			scoreManager.AddPoints(points);
			Destroy(gameObject);
		}
	}
}
