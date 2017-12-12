using System.Collections; 
using UnityEngine; 
 
public class SpawnManager : MonoBehaviour {

public float chickenSpawnTime = 5f;
public float wolfSpawnTime = 15;
public float goldenChickenSpawnTime = 20f;
public float gCWolfSpawnTime = 20f;
public float cWolfSpawnTime = 10f;
public Transform chickenSpawn1;
public Transform chickenSpawn2;
public Transform chickenSpawn3;
public Transform chickenSpawn4;
public Transform chickenSpawn5;
public Transform wolfSpawn1;
public Transform wolfSpawn2;
public Transform wolfSpawn3;
public Transform wolfSpawn4;
public Transform wolfSpawn5;
Transform[] spawnPoints = new Transform [10];
public GameObject chicken;
public GameObject gChickenHunter;
public GameObject playerHunter;
public GameObject chickenHunter;
public GameObject goldenChicken;


    void Start(){
		InvokeRepeating ("SpawnChicken", chickenSpawnTime, chickenSpawnTime);
		InvokeRepeating ("SpawnPlayerHunter", wolfSpawnTime, wolfSpawnTime);
		InvokeRepeating ("SpawnChickenHunter", cWolfSpawnTime, cWolfSpawnTime);
		InvokeRepeating ("SpawnGoldenChickenHunter", gCWolfSpawnTime, gCWolfSpawnTime);
		InvokeRepeating ("SpawnGoldenChicken", goldenChickenSpawnTime, goldenChickenSpawnTime);
        spawnPoints [0] = chickenSpawn1;
        spawnPoints [1] = chickenSpawn2;
        spawnPoints [2] = chickenSpawn3;
        spawnPoints [3] = chickenSpawn4;
        spawnPoints [4] = chickenSpawn5;
        spawnPoints [5] = wolfSpawn1;
        spawnPoints [6] = wolfSpawn2;
        spawnPoints [7] = wolfSpawn3;
        spawnPoints [8] = wolfSpawn4;
        spawnPoints [9] = wolfSpawn5;
    }		
    void SpawnChicken(){
        int chickenSpawnPointIndex = Random.Range(0,4);
			Instantiate (chicken, spawnPoints [chickenSpawnPointIndex].position, spawnPoints [chickenSpawnPointIndex].rotation);
	}
    void SpawnPlayerHunter(){
        int wolfSpawnPointIndex = Random.Range(5,9);
		Instantiate (playerHunter, spawnPoints[wolfSpawnPointIndex].position, spawnPoints[wolfSpawnPointIndex].rotation);
	}
	void SpawnChickenHunter(){
		int wolfSpawnPointIndex = Random.Range(5,9);
		Instantiate (chickenHunter, spawnPoints[wolfSpawnPointIndex].position, spawnPoints[wolfSpawnPointIndex].rotation);
	}
	void SpawnGoldenChickenHunter(){
		int wolfSpawnPointIndex = Random.Range(5,9);
		Instantiate (gChickenHunter, spawnPoints[wolfSpawnPointIndex].position, spawnPoints[wolfSpawnPointIndex].rotation);
	}
    void SpawnGoldenChicken(){
		int goldenChickenSpawnPointIndex = Random.Range(0,4);
			Instantiate (goldenChicken, spawnPoints [goldenChickenSpawnPointIndex].position, spawnPoints [goldenChickenSpawnPointIndex].rotation);
	}  
}