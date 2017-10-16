/***************************************************************************
Project:      RacerJumper
Copyright (c) Samuel
Author:       Samuel Salas(samuel.salas.fernandez@gmail.com)
***************************************************************************/
using UnityEngine;
using System.Collections;

public class PlayerMov : BaseHMov {
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
	protected override void Start ()
	{
		base.Start ();
		switch (StartDir)
		{
		case HMovDir.LEFT:
			Player.Instance.transform.Rotate(0, 180, 0);
			break;

		case HMovDir.RIGTH:
			Player.Instance.transform.Rotate(0, 0, 0);
			break;
		}
	}

	public override void doSomeThingWhenPosIsLeftLimit ()
	{
		base.doSomeThingWhenPosIsLeftLimit ();
		Player.Instance.transform.Rotate(0, 180, 0);
	}

	public override void doSomeThingWhenPosIsRightLimit ()
	{
		base.doSomeThingWhenPosIsRightLimit ();
		Player.Instance.transform.Rotate(0, 180, 0);
	}
	#endregion
	
	
	//--------------------------------------
	// Unity Methods
	//--------------------------------------
	#region Unity

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
