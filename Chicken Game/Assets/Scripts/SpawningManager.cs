using System.Collections; 
using UnityEngine; 
 
public class SpawningManager : MonoBehaviour {

private float chickenSpawnCountdown;
private float wolfSpawnCountdown;

    void Start(){
        chickenSpawnCountdown = Random.Range(1f,3f);
        wolfSpawnCountdown = Random.Range(5f,8f);
    }

    void Update(){
        chickenSpawnCountdown -= Time.deltaTime;
        wolfSpawnCountdown -= Time.deltaTime;
        if(chickenSpawnCountdown <= 0){
            SpawnChicken();
            chickenSpawnCountdown = Random.Range(1f,3f);
        }
        if(wolfSpawnCountdown<=0){
            SpawnWolf();
            wolfSpawnCountdown = Random.Range(5f,8f);
        }
    }
    void SpawnChicken();
        
}