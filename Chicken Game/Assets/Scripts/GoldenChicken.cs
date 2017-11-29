using System.Collections; 
using UnityEngine; 
 
public class GoldenChicken : MonoBehaviour { 
 
 public Rigidbody enemy; 
  public float moveSpeed; 
  public Transform target; 
  public Transform chickenPen; 
  public int points = 20; 
  public int badPoints = 10;
  public float jumpHeight;
  private float jumpCountdown;
  public int goldenChickenHealth = 3;

  void Start(){
    jumpCountdown = Random.Range(1f,7f);
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
      goldenChickenHealth -= 1;
      if(goldenChickenHealth <= 0){
          Destroy(gameObject);
        }
      }
    }
  void Update(){
    jumpCountdown -= Time.deltaTime;
    if(jumpCountdown <= 0){
        jumpCountdown = Random.Range(1f,7f);
        Jump();
    }
  }
  void Jump(){
    RigidBody jumper = GetComponent<RigidBody>();
    jumper.velocity = new Vector3(0,jumpHeight,0);
    
  }
  
} 