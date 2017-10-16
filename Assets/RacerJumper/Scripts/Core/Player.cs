/***************************************************************************
Project:      RacerJumper
Copyright (c) Samuel
Author:       Samuel Salas(samuel.salas.fernandez@gmail.com)
***************************************************************************/
using UnityEngine;
using System.Collections;

public class Player : Singleton<Player> {
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
//	[SerializeField]
//	private 
	
	#endregion
	
	
	//--------------------------------------
	// Private Attributes
	//--------------------------------------
	#region Private Attributes
	private bool collidingWithPlatform = false;
	private bool collidingWithEnemy = false;
	private bool jumping=false;
	#endregion
	
	
	//--------------------------------------
	// Getters/Setters
	//--------------------------------------
	#region Getters/Setters
	public bool Jumping {
		get {
			return this.jumping;
		}
		set {
			jumping = value;
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
	void OnCollisionStay(Collision collisionInfo){
		collidingWithPlatform = collisionInfo.collider.tag=="Platform";
		collidingWithEnemy = collisionInfo.collider.tag == "Enemy";
		if (collidingWithPlatform){
			Jumping = false;
		}
	}
	void OnCollisionExit(Collision collisionInfo){
		collidingWithPlatform = false;

		Jumping = true;
	}


	public void reset(){
	
		collidingWithPlatform = false;
		collidingWithEnemy = false;
		jumping=false;

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
	public bool isCollidingWithPlatform(){
		return collidingWithPlatform;
	}
	public bool isCollidingWithEnemy(){
		return collidingWithEnemy;
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
