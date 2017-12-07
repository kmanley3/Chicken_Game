using System.Collections; 
using UnityEngine; 
 
public class Domestication : MonoBehaviour {

    public Rigidbody enemy;
	public float moveSpeed;
	public Transform target;
	public int damage;
	public GameObject enemyHealth;
    // public GameObject wolfBehavior;
    // public Material changeMaterial;
    bool isDomesticated = false;
    public GameObject wolfBehavior;
    void OnTriggerStay(Collider other){
        if(other.gameObject.name == "Player"){
            if (Input.GetKeyDown(KeyCode.F))
                Debug.Log("F was pressed. Domestication???");
                Domesticate(isDomesticated);
        }
        if(other.gameObject.name == "Wolf" && wolfBehavior == false && isDomesticated == true){
            Debug.Log("Wolf is being chased off!");
            transform.LookAt(target);
            transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);
        }
    }

    void Domesticate(bool isDomesticated){
        var wolfBehavior = this.gameObject.GetComponent<WolfAI>();
            wolfBehavior.enabled = false;
        // changeMaterial.color = Color.gray;
        isDomesticated = true;
        
    }

    void OnCollisionEnter (Collision other){
		
		if(other.gameObject.name == "Wolf" && wolfBehavior == false && isDomesticated == true){
		
			print("Wolf is being attacked!");
			var hit = other.gameObject;
			var health = hit.GetComponent<wolfHealth>();
		
			if(enemyHealth !=null){
				// pcHealth.TakeDamage(damage);
				enemyHealth.gameObject.GetComponent<wolfHealth>().TakeDamage(damage);
			}
		}
    }
}