using System.Collections;
using UnityEngine;

public class WolfAI : MonoBehaviour {

	public Rigidbody enemy;
	public float moveSpeed;
	public Transform target;
	public int damage;
	public GameObject pcHealth;
	
	void OnTriggerStay (Collider other)
	{

		if(other.gameObject.name == "Player"){
			Debug.Log("Wolf is following!");
			transform.LookAt(target);
			transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);
		}
	}

	void OnCollisionEnter (Collision other){
		
		if(other.gameObject.name == "Player"){
		
			print("Wolf is attacking!");
			var hit = other.gameObject;
			var health = hit.GetComponent<playerHealth>();
		
			if(pcHealth !=null){
				// pcHealth.TakeDamage(damage);
				pcHealth.gameObject.GetComponent<playerHealth>().TakeDamage(damage);
			}
		}
		
	}


}