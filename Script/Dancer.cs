using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Dancer : MonoBehaviour {
	
	public GameObject head;
	public GameObject upperRightArm;
	public GameObject lowerRightArm;
	public GameObject upperLeftArm;
	public GameObject lowerLeftArm;
	public GameObject middleSpine;
	public GameObject root;
	public GameObject upperRightLeg;
	public GameObject lowerRightLeg;
	public GameObject upperLeftLeg;
	public GameObject lowerLeftLeg;
	
	public DanceStance currentStance;
	
	public GameObject[] danceLimbs;
	
	public DanceStance[] stances;
		
	// Use this for initialization
	void Start () 
	{
	
		initializeDancer();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	
	
	}
	
	
	
	public void initializeDancer()
	{
		/*
			danceLimbs = new GameObject[11];
			danceLimbs[0] = head;
			danceLimbs[1] =	upperRightArm;
			danceLimbs[2] = lowerRightArm;
			danceLimbs[3] = upperLeftArm;
			danceLimbs[4] = lowerLeftArm;
			danceLimbs[5] = middleSpine;
			danceLimbs[6] = root;
			danceLimbs[7] = upperRightLeg;
			danceLimbs[8] = lowerRightLeg;
			danceLimbs[9] = upperLeftLeg;
			danceLimbs[10] = lowerLeftLeg;
			*/
		
			danceLimbs = new GameObject[11];
			danceLimbs[0] = root;
			danceLimbs[1] =	upperRightLeg;
			danceLimbs[2] = upperLeftLeg;
			danceLimbs[3] = lowerRightLeg;
			danceLimbs[4] = lowerLeftLeg;
			danceLimbs[5] = middleSpine;
			danceLimbs[6] = head;
			danceLimbs[7] = upperRightArm;
			danceLimbs[8] = upperLeftArm;
			danceLimbs[9] = lowerRightArm;
			danceLimbs[10] = lowerLeftArm;
		
			for(int i = 0 ; i < danceLimbs.Length ; i ++)
				{
			
					danceLimbs[i].rigidbody.isKinematic = true;
			
				}
		
	}
	
	
	public void changeStance(DanceStance newStance)
	{
	
		Debug.Log("CHANGING STANCE TO " + newStance.gameObject.name);
		
		for(int i = 0 ; i < newStance.stanceTargets.Length ; i ++)
			{
									danceLimbs[i].rigidbody.isKinematic = true;

				
				Debug.Log("ANALYZING DANCE LIMB " + danceLimbs[i].name);
			
				if(newStance.stanceTargets[i] != null)
					{
				
					Debug.Log("CORRESPONDING LOCK FOUND");
				
						danceLimbs[i].rigidbody.isKinematic = true;
						danceLimbs[i].transform.rotation = newStance.stanceTargets[i].transform.rotation;
						danceLimbs[i].transform.position = newStance.stanceTargets[i].transform.position;

					Debug.Log(" DANCE LIMB " + danceLimbs[i].name + " KINEMATIC STATUS = " + danceLimbs[i].rigidbody.isKinematic);
				
					}else{
				
						danceLimbs[i].rigidbody.isKinematic = false;
						danceLimbs[i].transform.rotation = danceLimbs[i].GetComponent<DanceLimb>().initialRotation;
						danceLimbs[i].transform.position = danceLimbs[i].GetComponent<DanceLimb>().initialPosition;
				
					}
			
			}
		
		
		currentStance = newStance;
		
	}
	
	
	public void applyForce(Vector3 forceDirection)
	{
		
		for(int i = 0 ; i < danceLimbs.Length ; i ++)
			{
			
				danceLimbs[i].rigidbody.AddForce(forceDirection,ForceMode.Impulse);
			
			}
		
	}
	

}
