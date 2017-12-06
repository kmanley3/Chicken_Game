using System.Collections; 
using UnityEngine; 
 
public class Domestication : MonoBehaviour {

    public Rigidbody enemy;
	public float moveSpeed;
	public Transform target;
	public int damage;
	public GameObject enemyHealth;
    public Material changeMaterial;


    void OnTriggerStay(Collider other){
        if(other.gameObject.name == "Player"){
            if (Input.GetKeyDown(KeyCode.F))
                Debug.Log("F was pressed. Domestication???");
                Domesticate();
                return;
        }
    }

    void Domesticate(){
        GetComponent(WolfAI).enabled = false;
        changeMaterial.color = Color.gray;
        
    }

    void OnTriggerStay (Collider other){
        if(other.gameObject.name == "Wolf" && GetComponent(WolfAI).enabled == true && Domesticate()){
            private float chaseSpeed = moveSpeed*1.3
            Debug.Log("Wolf is being chased off!");
            transform.LookAt(target);
            transform.Translate(Vector3.forward*chaseSpeed*Time.deltaTime);
        }
    }

    void OnCollisionEnter (Collision other){
		
		if(other.gameObject.name == "Wolf" && GetComponent(WolfAI).enabled == true && Domesticate()){
		
			print("Wolf is being attacked!");
			var hit = other.gameObject;
			var health = hit.GetComponent<wolfHealth>();
		
			if(enemyHealth !=null){
				// pcHealth.TakeDamage(damage);
				enemyHealth.gameObject.GetComponent<wolfHealth>().TakeDamage(damage);
			}
		}
}