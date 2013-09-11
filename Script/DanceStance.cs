using UnityEngine;
using System.Collections;

public class DanceStance : MonoBehaviour {
	
	public string stanceName = "";
	
	public Dancer dancer;
	
	public Transform head;
	public Transform upperRightArm;
	public Transform lowerRightArm;
	public Transform upperLeftArm;
	public Transform lowerLeftArm;
	public Transform middleSpine;
	public Transform root;
	public Transform upperRightLeg;
	public Transform lowerRightLeg;
	public Transform upperLeftLeg;
	public Transform lowerLeftLeg;
	
	public Transform[] stanceTargets;
	
	// Use this for initialization
	void Start () {
		
		initializeTargets();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	
	
	public void initializeTargets()
		{
		/*
		 * 	danceLimbs[0] = root;
			danceLimbs[1] =	upperRightLeg;
			danceLimbs[2] = lowerLeftLeg;
			danceLimbs[3] = upperLeftLeg;
			danceLimbs[4] = lowerLeftLeg;
			danceLimbs[5] = middleSpine;
			danceLimbs[6] = head;
			danceLimbs[7] = upperRightArm;
			danceLimbs[8] = upperLeftArm;
			danceLimbs[9] = lowerRightLeg;
			danceLimbs[10] = lowerLeftArm;
			*/
			stanceTargets = new Transform[11];
			stanceTargets[0] = root;
			stanceTargets[1] =	upperRightLeg;
			stanceTargets[2] = upperLeftLeg;
			stanceTargets[3] = lowerRightLeg;
			stanceTargets[4] = lowerLeftLeg;
			stanceTargets[5] = middleSpine;
			stanceTargets[6] = head;
			stanceTargets[7] = upperRightArm;
			stanceTargets[8] = upperLeftArm;
			stanceTargets[9] = lowerRightArm;
			stanceTargets[10] = lowerLeftArm;
		
		}
	
	
	
	
	
}
