/***************************************************************************
Project:      RacerJumper
Copyright (c) Samuel
Author:       Samuel Salas(samuel.salas.fernandez@gmail.com)
***************************************************************************/
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class GuiManager : Singleton<GuiManager> {
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
	private Text textScore;
	[SerializeField]
	private Text textScore2;
	[SerializeField]
	private PauseWin pauseWin;
	#endregion
	
	
	//--------------------------------------
	// Private Attributes
	//--------------------------------------
	#region Private Attributes
	private List<BaseWindow> windows;
	#endregion
	
	
	//--------------------------------------
	// Getters/Setters
	//--------------------------------------
	#region Getters/Setters
	public Text TextScore {
		get {
			return this.textScore;
		}
		set {
			textScore = value;
		}
	}

	public Text TextScore2 {
		get {
			return this.textScore2;
		}
		set {
			textScore2 = value;
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
	public void Awake(){
		BaseWindow[] w=(BaseWindow[])FindObjectsOfType<BaseWindow> ();
		windows = new List<BaseWindow> (w);
	
		foreach (BaseWindow aux in windows) {
		
			if (aux.CloseAtStart) {
				aux.gameObject.SetActive (false);
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
	public void openWindow(string id, bool show=true){
		BaseWindow auxWindow;
		auxWindow = windows.Find (x => x.IdWindow == id);
		if (auxWindow != null)
			auxWindow.gameObject.SetActive (show);
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
