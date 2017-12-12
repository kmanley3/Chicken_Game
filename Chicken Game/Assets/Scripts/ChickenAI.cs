using System.Collections; 
using UnityEngine; 
 
public class ChickenAI : MonoBehaviour { 
 
  public Rigidbody enemy; 
  public float moveSpeed; 
  public Transform target; 
  public Transform chickenPen; 
  public int points = 10; 
  public int badPoints = 5;
	public GameObject pcHealth;
	public int heals;

	void Start(){
    MoveForward();
  }

  void MoveForward(){
    transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);
}
  void OnTriggerStay (Collider other) 
  { 
		if (other.gameObject.name == "Player") {
			if (Input.GetKeyDown (KeyCode.F)) {
				Eat ();
			} else {
				Debug.Log ("Player has entered chickens trigger"); 
				transform.LookAt (target); 
				transform.Translate (Vector3.back * moveSpeed * Time.deltaTime);
				var ChickenWander = this.gameObject.GetComponent<Chicken_Wander> ();
				ChickenWander.enabled = false;
			}
		} else if (other.gameObject.tag == "Wolf") { 
			Debug.Log ("Wolf has entered chickens trigger"); 
			transform.LookAt (target); 
			transform.Translate (Vector3.back * moveSpeed * Time.deltaTime);
			var ChickenWander = this.gameObject.GetComponent<Chicken_Wander> ();
			ChickenWander.enabled = false;	  
		}
    
  }
	void OnTriggerExit (Collider other){
	if (other.gameObject.name == "Player" || other.gameObject.tag == "Wolf"){
		var ChickenWander = this.gameObject.GetComponent<Chicken_Wander> ();
		ChickenWander.enabled = true;
	}
	}
		
  void OnCollisionEnter(Collision other) 
  { 
    if(other.gameObject.name == "Player"){ 
    scoreManager.AddPoints(points); 
    transform.position = chickenPen.position; 
    transform.rotation = chickenPen.rotation; 
      }
    if(other.gameObject.tag == "Wolf"){
      scoreManager.SubtractPoints(badPoints);
      Destroy(gameObject);
      }
    }



	void Eat(){
		if (pcHealth != null) {
			pcHealth.gameObject.GetComponent<playerHealth> ().GainHealth (heals);
		}
		scoreManager.SubtractPoints(badPoints);
		Destroy (this.gameObject);
	}
  
}

//make it spicy