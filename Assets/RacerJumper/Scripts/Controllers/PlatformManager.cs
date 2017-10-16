/***************************************************************************
Project:      RacerJumper
Copyright (c) Samuel
Author:       Samuel Salas(samuel.salas.fernandez@gmail.com)
***************************************************************************/
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlatformManager : Singleton<PlatformManager> {
	//--------------------------------------
	//  EVENTS && ACTIONS
	//--------------------------------------
	#region Events & Actions
	
	#endregion
	
	//--------------------------------------
	// Static Attributes
	//--------------------------------------
	#region Static Attributes
	
	#endregion
	
	//--------------------------------------
	// Constants
	//--------------------------------------
	#region Constants
	
	#endregion
	
	//--------------------------------------
	// Setting Attributes
	//--------------------------------------
	#region Setting Attributes

	[SerializeField]
	private List<Platform> platformList;
	[SerializeField]
	private float distanceBetweenPlatform = 3;
	[SerializeField]
	private float myPosition = 0;

	[SerializeField]
	private Platform platform;

	[SerializeField]
	private GameObject enemy;

	[SerializeField]
	private int initialPlatformsNumber=0;


	#endregion

	
	//--------------------------------------
	// Private Attributes
	//--------------------------------------
	#region Private Attributes
	private float nextPlatformPosition;
	private float nextEnemyPosition;

	#endregion
	
	
	//--------------------------------------
	// Getters/Setters
	//--------------------------------------
	#region Getters/Setters
	public float DistanceBetweenPlatform {
		get {
			return this.distanceBetweenPlatform;
		}
	}
	#endregion
	
	
	//--------------------------------------
	// Overriden Methods
	//--------------------------------------
	#region Overriden Methods
	
	#endregion
	
	
	//--------------------------------------
	// Unity Methods
	//--------------------------------------
	#region Unity
	void Awake(){
		nextPlatformPosition = initialPlatformsNumber*distanceBetweenPlatform;
		nextEnemyPosition = initialPlatformsNumber * distanceBetweenPlatform + myPosition;
		spawn ();

	}
	void Update(){
		if(Player.Instance.Jumping && (Player.Instance.transform.position.y) > (myPosition+distanceBetweenPlatform)){
			platformList [0].GetComponent<Collider> ().isTrigger = false;
			platformList.RemoveAt (0);
			Player.Instance.Jumping = false;
			myPosition += distanceBetweenPlatform;
			GameManager.Instance.newScore ();
		}	
		if (platformList.Count < 5)
			spawn ();

	}
	#endregion
	
	
	
	//--------------------------------------
	// Private Methods
	//--------------------------------------
	#region Private Methods
	private void spawn (){
		for (int i = 0; i < 5; i++) {
			Platform p = platform.Spawn (new Vector3 (0, nextPlatformPosition, 0));
			platformList.Add (p);
			if(Random.value<0.6)
				enemy.Spawn (new Vector3 (0, nextEnemyPosition, 0));
			nextPlatformPosition += distanceBetweenPlatform;
			nextEnemyPosition += distanceBetweenPlatform;
		}

	}
	#endregion
	
	
	//--------------------------------------
	// Public Methods
	//--------------------------------------
	#region Public Methods
	
	#endregion
	
	//--------------------------------------
	// Statics Methods
	//--------------------------------------
	#region Statics Methods

	#endregion
	
	//--------------------------------------
	//  Events Handlers Methods
	//--------------------------------------
	#region Events
	
	#endregion
	
	
}
