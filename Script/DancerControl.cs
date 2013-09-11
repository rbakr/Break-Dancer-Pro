using UnityEngine;
using System.Collections;

public class DancerControl: MonoBehaviour {
	
	public float globalForceModifier;
	public float currentForce;
	public float globalForceAcceleration;
	public GameObject dancerObject;
	public Dancer dancer;
	
	// Use this for initialization
	void Start () {
		
		initializeController();
	
	}
	
	// Update is called once per frame
	void Update () {
		
			if(Input.GetKeyDown(KeyCode.S))
				{
			
					dancer.changeStance(dancer.stances[Random.Range(0,dancer.stances.Length)]);
					
				}
		
			
		
		
			if(Input.GetKeyDown(KeyCode.D))
			{
				
				dancer.changeStance(dancer.currentStance);
			
			}
		
		if(Input.GetKey(KeyCode.UpArrow))
			{
			
				dancer.applyForce(Vector3.up * currentForce);
				currentForce += globalForceAcceleration;
			}
		if(Input.GetKey(KeyCode.DownArrow))
			{
			
				dancer.applyForce(-Vector3.up * currentForce);
								currentForce += globalForceAcceleration;

			}
		if(Input.GetKey(KeyCode.RightArrow))
			{
			
				dancer.applyForce(Vector3.right * currentForce);
							currentForce += globalForceAcceleration;

			}
		if(Input.GetKey(KeyCode.LeftArrow))
			{
			
				dancer.applyForce(-Vector3.right * currentForce);
							currentForce += globalForceAcceleration;

			}
		
		if(!Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow)
			&& !Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.DownArrow))
			{
			
				currentForce = globalForceModifier;
			
			}
	
	}
	
	
	
	
	
	
	public void initializeController()
	{
		
		
		if(dancerObject != null)
			{
			
				dancer = dancerObject.GetComponent<Dancer>();
			
			}
	}
}
