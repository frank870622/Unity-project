using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.x > 178.6)
        {
            transform.position = new Vector3((float)178.6, transform.position.y, transform.position.z);
        }
        if(transform.position.z > 137.9)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, (float)137.9);
        }
        if(transform.position.x < -178.6)
        {
            transform.position = new Vector3((float)-178.6, transform.position.y, transform.position.z);
        }
        if(transform.position.z < -137.9)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, (float)-137.9);
        }
	}
}
