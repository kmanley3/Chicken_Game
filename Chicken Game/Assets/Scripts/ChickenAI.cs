using System.Collections; 
using UnityEngine; 
 
public class ChickenAI : MonoBehaviour { 
 
  public Rigidbody enemy; 
  public float moveSpeed; 
  public Transform target; 
  public Transform chickenPen; 
  public int points = 10; 
  public int badPoints = 5;
  public float jumpHeight;
  private float jumpCountdown;

  void Start(){
    jumpCountdown = Random.Range(1f,7f);
    MoveForward();
  }

  void MoveForward(){
    transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);
}
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
    if(other.gameObject.name == "Player"){ 
    scoreManager.AddPoints(points); 
    transform.position = chickenPen.position; 
    transform.rotation = chickenPen.rotation; 
      }
    if(other.gameObject.name == "Wolf"){
      scoreManager.SubtractPoints(badPoints);
      Destroy(gameObject);
      }
    }
  // void Update(){
  //   jumpCountdown -= Time.deltaTime;
  //   if(jumpCountdown <= 0){
  //       jumpCountdown = Random.Range(1f,7f);
  //       Jump();
  //   }
  // }
  // void Jump(){
  //   RigidBody jumper = GetComponent<RigidBody>();
  //   jumper.velocity = new Vector3(0,jumpHeight,0);
    
  // }
  
} 

//make it spicy