using System.Collections; 
using UnityEngine; 
 
public class GoldenChicken : MonoBehaviour { 
 
 public Rigidbody enemy; 
  public float moveSpeed; 
  public Transform target; 
  public Transform chickenPen; 
  public int points = 20; 
  public int badPoints = 10;
  public int goldenChickenHealth = 3;

  void OnTriggerStay (Collider other) 
  { 
    if(other.gameObject.name == "Wolf"){ 
      Debug.Log("Wolf has entered chickens trigger"); 
      transform.LookAt(target); 
      transform.Translate(Vector3.back*moveSpeed*Time.deltaTime);
    }
    else if(other.gameObject.name == "Player"){ 
      Debug.Log("Player has entered chickens trigger"); 
      transform.LookAt(target); 
      transform.Translate(Vector3.back*moveSpeed*Time.deltaTime);
    }  
  } 
  void OnCollisionEnter(Collision other)
	{ 
		if (other.gameObject.name == "Player") { 
			scoreManager.AddPoints (points); 
			transform.position = chickenPen.position; 
			transform.rotation = chickenPen.rotation; 
		}
	}  
} 