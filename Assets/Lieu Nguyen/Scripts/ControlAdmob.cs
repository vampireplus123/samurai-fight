using UnityEngine;
using System.Collections;

public class ControlAdmob : MonoBehaviour 
{

	// Use this for initialization
	void Start ()
	{
		if (GameObject.Find ("RevMob") != null) 			
		{			
			GameObject.Find ("RevMob").GetComponent<RevMobAds> ().AppLovinFullScreen ();
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
