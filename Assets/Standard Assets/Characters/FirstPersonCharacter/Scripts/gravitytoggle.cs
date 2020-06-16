using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityStandardAssets.Characters.FirstPerson {

public class gravitytoggle : MonoBehaviour {
	bool  flight = false;
	float gravityoff = -1;
	float gravityon = 1;
// decleared flight var. and on and off values which can be acessed outside of script.
	void  Start ()
	{
		FirstPersonController.m_GravityMultiplier = 1;
	}


	void  Update ()
	{
//when you press f toggle flight var.
		if(Input.GetKey("f"))
		{
			flight = true;
		}
		else
		{	 
			flight = false;
		}
//if flight var= true set gravity to -1 otherwise set to 1.
		if(flight == true)
		{
			FirstPersonController.m_GravityMultiplier = gravityoff;
		}
		else
		{
			FirstPersonController.m_GravityMultiplier = gravityon;

		}
	}
}
}
