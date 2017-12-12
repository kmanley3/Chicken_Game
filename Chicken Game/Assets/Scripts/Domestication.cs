using System.Collections; 
using UnityEngine; 
 
public class Domestication : MonoBehaviour {

	public Rigidbody enemy;
	public float moveSpeed;
	public Transform target;

	void OnTriggerStay (Collider other)
	{

		if (other.gameObject.tag == "Wolf") {
			target = other.transform;
			Debug.Log ("Pupper is chasing!");
			transform.LookAt (target);
			transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
			var WolfWander = this.gameObject.GetComponent<Wolf_Wander> ();
			WolfWander.enabled = false;
		}
			else{
			var WolfWander = this.gameObject.GetComponent<Wolf_Wander> ();
			WolfWander.enabled = true;

				
		}
	}
}