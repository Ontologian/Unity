using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    Vector3 ang;
    Vector3 displace;
    Vector3 initialPos;
	// Use this for initialization
	void Start () {
        ang = new Vector3(10.001f, 20.02f, 30.3f);
        displace = new Vector3(0, 0, 0);
        initialPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        displace = new Vector3(0f, 0.25f * Mathf.Sin(Time.time), 0f);
        transform.Rotate(ang * Time.deltaTime);
        transform.position = initialPos + displace;
	}
}
