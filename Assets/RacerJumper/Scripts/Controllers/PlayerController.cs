/***************************************************************************
Project:      RacerJumper
Copyright (c) Samuel
Author:       Samuel Salas(samuel.salas.fernandez@gmail.com)
***************************************************************************/
using UnityEngine;
using System.Collections;

public class PlayerController : Singleton<PlayerController> {
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
	private float forceJump1=50;
	[SerializeField]
	private float forceJump2=100;
	[SerializeField]
	private float durJump1 = 15;

	#endregion
	
	
	//--------------------------------------
	// Private Attributes
	//--------------------------------------
	#region Private Attributes
	private float curTime = 0;
	private float initTime = 0;
	#endregion
	
	
	//--------------------------------------
	// Getters/Setters
	//--------------------------------------
	#region Getters/Setters
	
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

	void Update(){
  		curTime = Time.realtimeSinceStartup;
		if (Player.Instance.isCollidingWithEnemy() && Time.timeScale!=0) {
			Time.timeScale = 0;
			Camera.main.GetComponent<AudioSource>().Stop();
			GuiManager.Instance.openWindow ("gameover");
			Player.Instance.reset ();
		}
			
		if (Input.GetMouseButtonDown (0) && Player.Instance.isCollidingWithPlatform()) {
			initTime = Time.realtimeSinceStartup;
		}
		if (Input.GetMouseButtonUp (0) && Player.Instance.isCollidingWithPlatform ()) {
			Player.Instance.GetComponent<AudioSource>().Play();
			if (curTime - initTime <= durJump1 && curTime - initTime >= 0)
				jump ();
			else if (curTime - initTime >= durJump1)
				jump (1);
		}
	}


	#endregion
	
	
	
	//--------------------------------------
	// Private Methods
	//--------------------------------------
	#region Private Methods
	
	#endregion
	
	
	//--------------------------------------
	// Public Methods
	//--------------------------------------
	#region Public Methods

	public void jump(int jumpIndex = 0){
		if(jumpIndex == 0)
			Player.Instance.GetComponent<Rigidbody> ().AddForce(Vector3.up*forceJump1);
		else if(jumpIndex == 1)
			Player.Instance.GetComponent<Rigidbody> ().AddForce(Vector3.up*forceJump2);
	
	}

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
