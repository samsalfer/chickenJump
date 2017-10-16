/***************************************************************************
Project:      RacerJumper
Copyright (c) Samuel
Author:       Samuel Salas(samuel.salas.fernandez@gmail.com)
***************************************************************************/
using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
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
	[SerializeField]
	private bool isInitial = false;

	[SerializeField]
	private Material material;
	#endregion
	
	
	//--------------------------------------
	// Private Attributes
	//--------------------------------------
	#region Private Attributes
	
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
	void LateUpdate (){
		if ((Player.Instance.GetComponent<Collider> ().transform.position.y - gameObject.GetComponent<Collider> ().transform.position.y) >= PlatformManager.Instance.DistanceBetweenPlatform) {
			if (!isInitial) {
				gameObject.Recycle ();
			} else {
				Destroy (gameObject);
			}
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
	public void doFaster(){
		GetComponent<Renderer> ().material = material;
	
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
