using UnityEngine;
using System.Collections;

public class DanceCamera : MonoBehaviour {

	
	public float rotationSpeed = 2.0f;
	public Transform target;
	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		rotateAroundTarget(target);
	
	}
	
	
	
	
	public void rotateAroundTarget(Transform target)
	{
		
		transform.RotateAround(target.position, Vector3.up, rotationSpeed * Time.deltaTime);
		
	}
	
}
