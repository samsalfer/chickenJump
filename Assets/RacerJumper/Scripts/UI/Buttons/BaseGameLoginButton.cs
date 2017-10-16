/***************************************************************************
Project:      RacerJumper
Copyright (c) Samuel
Author:       Samuel Salas(samuel.salas.fernandez@gmail.com)
***************************************************************************/
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BaseGameLoginButton : MonoBehaviour {
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
	private GameState state;

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
	public void press(){
		switch (state) {
		case GameState.RESUME:
			GuiManager.Instance.openWindow ("learn", false);
			GuiManager.Instance.openWindow ("pause", false);
			GuiManager.Instance.openWindow ("gameover", false);
			Time.timeScale = 1;
			break;
		case GameState.PAUSE:
			Time.timeScale = 0;
			GuiManager.Instance.openWindow ("pause");
			break;
		case GameState.RETRY:
			SceneManager.LoadScene(SceneManager.GetActiveScene ().name);
			GuiManager.Instance.openWindow ("pause", false);
			GuiManager.Instance.openWindow ("gameover", false);
			Time.timeScale = 1;

			break;
		case GameState.EXIT:
			Application.Quit ();
			break;
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
