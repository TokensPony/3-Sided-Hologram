using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotation : MonoBehaviour {

	public float xDegrees;
	public float yDegrees;
	public float zDegrees;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (xDegrees * Time.deltaTime, yDegrees * Time.deltaTime, zDegrees * Time.deltaTime);
	}
}
