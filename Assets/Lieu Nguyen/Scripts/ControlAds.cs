using UnityEngine;
using System.Collections;
using ChartboostSDK;

public class ControlAds : MonoBehaviour 
{
	bool _showChartBoost = false;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{	
		Chartboost.cacheInterstitial(CBLocation.Default);
		if (Chartboost.hasInterstitial (CBLocation.Default) && _showChartBoost == false) 
		{
			Chartboost.showInterstitial (CBLocation.Default);
			_showChartBoost = true;
			print("Show Chartboost");
		}
	}
}
