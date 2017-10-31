using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfAI : MonoBehaviour {

	public Rigidbody enemy;
	public float moveSpeed;
	public Transform target;
	
	void OnTriggerStay (Collider other)
	{

		if(other.gameObject.name == "Player"){
			Debug.Log("Player has entered wolf's trigger");
			transform.LookAt(target);
			transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);
		}
	}
}