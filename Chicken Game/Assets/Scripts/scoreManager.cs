using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class scoreManager : MonoBehaviour {

	public static int score;
	public int winScore;
	public Text text;
	public Text winText;
	public Image winImage;


	void Start () {
		text = GetComponent<Text>();
		score = 0;
		winText.GetComponent<Text>().enabled = false;
		winImage.GetComponent<Image> ().enabled = false;
	}

	void Update () {
		text.text = score.ToString();
		if(score < 0){
			score = 0;

			text.text = " " + score;
		}
		if(winScore <= score){
			winText.GetComponent<Text>().enabled = true;
			winImage.GetComponent<Image> ().enabled = true;
		}
		if(Input.GetKeyDown(KeyCode.Escape)){
			SceneManager.LoadScene(0);
		}
	}
	public static void AddPoints(int pointsToAdd){
		score = score + pointsToAdd;
	}
	public static void SubtractPoints(int pointsToSubtract){
		score = score - pointsToSubtract;
	}

	public void Reset() {
		score=0;
	}

}