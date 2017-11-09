using System.Collections;
using UnityEngine;

public class Generic : MonoBehaviour {

public float posX;
public float posY;
public float posZ;

    void Start () {

    }
    void Update() {
        transform.position = new Vector3(posX,posY,posZ);
    }