using UnityEngine;
using System.Collections;

public class StrobeLight : MonoBehaviour {
	
	public float timeOn;
	public float timeOff;
	public float timeOfLastSwitch;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(light.intensity > 0)
			{
				if(Time.time - timeOfLastSwitch > timeOn)
					{
						
						light.intensity = 0;
						timeOfLastSwitch = Time.time;
				
					}
			}else if(light.intensity == 0)
			{
			
				if(Time.time - timeOfLastSwitch > timeOff)
					{
				
						light.intensity = 1;
						timeOfLastSwitch = Time.time;
					}
				
			
			}
		
		
	}
}
