using UnityEngine;
using System.Collections;
 
public class Wolf_Wander : MonoBehaviour{
public float moveSpeed;
private float countdown;
// public float jumpHeight;
// private float jumpCountdown;



void Start(){
    MoveForward();
    countdown = Random.Range(1f,5f);
    
}
void MoveForward(){
    transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);
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
    // jumpCountdown -= Time.deltaTime;
    // if(jumpCountdown <= 0){
    //     jumpCountdown = Random.Range(1f,7f);
    //     Jump();
    // }
}

// void Jump(){
//     RigidBody jumper = GetComponent<RigidBody>();
//     jumper.velocity = new Vector3(0,jumpHeight,0);
    
// }
    //  public float Speed = 7;
    //  Vector3 wayPoint;
    //  int Range = 10;
    //  void Start()
    //  {
    //      //initialise the target way point
    //      wander();
    //  }
 
    //  void Update()
    //  {
    //      // this is called every frame
    //      transform.position += transform.TransformDirection(Vector3.forward) * Speed * Time.deltaTime;
    //      if ((transform.position - wayPoint).magnitude < 3)
    //      {
             
    //          wander();
 
 
    //      }
    //  }
 
    //  void wander()
    //  {
    //      // does nothing except pick a new destination to go to
 
    //      wayPoint = new Vector3(Random.Range(transform.position.x - Range, transform.position.x + Range), 1, Random.Range(transform.position.z - Range, transform.position.z + Range));
    //      wayPoint.y = 1;
    //      // don't need to change direction every frame seeing as you walk in a straight line only
    //      transform.LookAt(wayPoint);
    //      Debug.Log(wayPoint + " and " + (transform.position - wayPoint).magnitude);
    //  }
 }