using UnityEngine;
using System.Collections;

public class Wander : MonoBehaviour {
    public float speed;
    public float directionChange;
    public float maxHeadingChange;

    CharacterController controller;
    float heading;
    Vector3 targetRotation;

    void Awake (){
        controller = GetComponent<CharacterController>();

        heading = Random.Range(0, 360);
        transform.eulerAngles = new Vector3(0, heading, 0);

        StartCoroutine(ChickenWander));
    }
    void Update (){
        transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, targetRotation, Time.deltaTime * directionChange);
        var forward = transform.TransformDirection(Vector3.forward);
        controller.SimpleMove(forward * speed);
    }
    IEnumerator ChickenWander (){
        while(true){
            ChickenWanderRoutine();
            yield return new WaitForSeconds(directionChange)
        }
    }
    void ChickenWanderRoutine (){
        var floor = Mathf.Clamp(heading - maxHeadingChange, 0, 360);
        var ceil = Mathf.Clamp(heading + maxHeadingChange, 0,360);
        heading = Random.Range(floor, ceil);
        targetRotation = new Vector3(0, heading, 0);
    }
}