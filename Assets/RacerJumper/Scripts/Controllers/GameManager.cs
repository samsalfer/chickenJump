/***************************************************************************
Project:      RacerJumper
Copyright (c) Samuel
Author:       Samuel Salas(samuel.salas.fernandez@gmail.com)
***************************************************************************/
using UnityEngine;
using System.Collections;

public class GameManager : Singleton<GameManager> {
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
	private int score; 

	
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
	public void newScore(){
	
		score++;
		GuiManager.Instance.TextScore.text = score.ToString();
		GuiManager.Instance.TextScore2.text = score.ToString();
	
	}
	public int scoreReturn {
		get {
			return this.score;
		}
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
