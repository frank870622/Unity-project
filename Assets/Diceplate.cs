using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diceplate : MonoBehaviour {
    public Camera camera;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(camera.transform.position.x, camera.transform.position.y - 20, camera.transform.position.z);
    }
}
