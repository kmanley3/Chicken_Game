using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playerHealth : MonoBehaviour {


public const int maxHealth = 10;
public int currentHealth = maxHealth;
public Text hp;
public Text maxHP;
public int loseScore;
public Text loseText;
	public Image loseImage;

	void Start(){
		
		loseText.GetComponent<Text> ().enabled = false;
		loseImage.GetComponent<Image> ().enabled = false;
	}
	void Update () {
		hp.text = currentHealth.ToString();
		maxHP.text = maxHealth.ToString();

		if(loseScore == currentHealth){
			loseText.GetComponent<Text>().enabled = true;
			loseImage.GetComponent<Image> ().enabled = true;
		}
		
	}
	public void TakeDamage(int amount){
		currentHealth -= amount;
		if(currentHealth <= 0){
			currentHealth=0;
			print("You're Dead! Game Over!");
		}
	}
	public void GainHealth(int quantity){
		currentHealth += quantity;
		if (currentHealth >= maxHealth) {
			currentHealth = maxHealth;
			print ("YOU ATE YOUR CHICKEN YOU MONSTER");
		}
	}

}
