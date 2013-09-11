using UnityEngine;
using System.Collections;

public class DanceLimb : MonoBehaviour {
	
	public Vector3 initialPosition;
	public Quaternion initialRotation;
	
	// Use this for initialization
	void Start () {
		
		initialPosition = transform.position;
		initialRotation = transform.rotation;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
