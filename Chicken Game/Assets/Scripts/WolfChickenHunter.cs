using System.Collections;
using UnityEngine;

public class WolfChickenHunter : MonoBehaviour {

	public Rigidbody enemy;
	public float moveSpeed;
	public Transform target;
	public int damage;
	public GameObject pcHealth;
	public GameObject pupper;
	public Transform pupperSpawner;

	void OnTriggerStay (Collider other)
	{
		if (other.gameObject.name == "Player") {
			if (Input.GetKeyDown (KeyCode.F)) {
				Transform pupperSpawn = pupperSpawner;
				Debug.Log ("F was pressed, but special.");
				Destroy (this.gameObject);
				Instantiate (pupper, pupperSpawn.position, pupperSpawn.rotation);
			}
			}
		else if (other.gameObject.name == "Chicken(Clone)") {
			target = other.transform;
			Debug.Log ("Wolf is following the Chicken!");
			transform.LookAt (target);
			transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
		}
		else {
			var WolfWander = this.gameObject.GetComponent<Wolf_Wander> ();
			WolfWander.enabled = true;
		}
	}

	void OnCollisionEnter (Collision other){

		if(other.gameObject.name == "Player"){

			print ("Wolf is attacking!");

			if(pcHealth !=null){
				pcHealth.gameObject.GetComponent<playerHealth>().TakeDamage(damage);
			}
		}

	}


}