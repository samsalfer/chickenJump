/***************************************************************************
Project:      RacerJumper
Copyright (c) Samuel
Author:       Samuel Salas(samuel.salas.fernandez@gmail.com)
***************************************************************************/
using UnityEngine;
using System.Collections;

public class EnemyMov : BaseHMov {
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
    protected override void Awake()
    {
        base.Awake();

        Vel = Random.Range(MinVel, MaxVel);



    }

	public void Start(){
	
		if (Vel >= (MaxVel + MinVel) / 2)
			GetComponent<Enemy> ().doFaster ();
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
