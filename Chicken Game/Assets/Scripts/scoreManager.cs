using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class scoreManager : MonoBehaviour {

	public static int score;
	public Text text;

	void Start () {
		text = GetComponent<Text>();
		score = 0;
	}

	void Update () {
		if(score < 0)
			score = 0;

		text.text = " " + score;
	}

	public static void AddPoints(int pointsToAdd){
		score += pointsToAdd;
	}

	public void Reset() {
		score=0;
	}
}