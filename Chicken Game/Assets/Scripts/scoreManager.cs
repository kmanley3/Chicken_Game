using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class scoreManager : MonoBehaviour {

	public static int score;
	public int winScore;
	public Text text;
	public Text winText;


	void Start () {
		text = GetComponent<Text>();
		score = 0;
		winText.GetComponent<Text>().enabled = false;
	}

	void Update () {
		if(score < 0){
			score = 0;

			text.text = " " + score;
		}
		if(winScore == score){
			winText.GetComponent<Text>().enabled = true;
			Time.timeScale = 0;
		}
		if(Input.GetKeyDown(KeyCode.Escape)){
			SceneManager.LoadScene(0);
		}
	}
	public static void AddPoints(int pointsToAdd){
		score += pointsToAdd;
	}
	public static void SubtractPoints(int pointsToSubtract){
		score -= pointsToSubtract;
	}

	public void Reset() {
		score=0;
	}

}