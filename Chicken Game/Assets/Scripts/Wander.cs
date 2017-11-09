 using UnityEngine;
 using System.Collections;
 
 public class Wander : MonoBehaviour{
public float moveSpeed;
void MoveForward(){
    transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);
}
void Turn(){
    int randomNum = Random.Range(0,360);
    transform.Rotate(0,randomNum,0);
}

void OnTriggerStay(Collider other){
    if(other.gameObject.tag == "CheckPoint"){
        Turn();
    }
    else{
        MoveForward();
    }
}

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