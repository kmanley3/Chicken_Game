using UnityEngine;
using System.Collections;

public class Chicken_Wander : MonoBehaviour{
	public float moveSpeed;
	private float countdown;

	void Start(){
		MoveForward();
		countdown = Random.Range(0.5f,3f);

	}
	void MoveForward(){
		transform.Translate(Vector3.back*moveSpeed*Time.deltaTime);
	}
	void Turn(){
		int randomNum = Random.Range(0,360);
		transform.Rotate(0,randomNum,0);
	}

	void Update(){
		countdown -= Time.deltaTime;
		MoveForward();
		if(countdown <= 0){
			countdown = Random.Range(0.5f,3f);
			Turn();

		}
	}
		
}