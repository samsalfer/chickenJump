/***************************************************************************
Project:      RacerJumper
Copyright (c) Samuel
Author:       Samuel Salas(samuel.salas.fernandez@gmail.com)
***************************************************************************/
using UnityEngine;
using System.Collections;

public class BaseHMov : MonoBehaviour {

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
    private float minVel = 0.5f;

    [SerializeField]
    private float maxVel = 2f;

    [SerializeField]
    private float vel = 1f;

    [SerializeField]
    private float limit = 3.2f;

    [SerializeField]
    private HMovDir startDir = HMovDir.LEFT;
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
    public float MinVel
    {
        get
        {
            return minVel;
        }

        set
        {
            minVel = value;
        }
    }

    public float MaxVel
    {
        get
        {
            return maxVel;
        }

        set
        {
            maxVel = value;
        }
    }

    public float Vel
    {
        get
        {
            return vel;
        }

        set
        {
            vel = value;
        }
    }

    public float Limit
    {
        get
        {
            return limit;
        }

        set
        {
            limit = value;
        }
    }

	public HMovDir StartDir {
		get {
			return this.startDir;
		}
		set {
			startDir = value;
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
    protected virtual void Awake()//Antes del start sirve para inicializaciones.
    {
        Vel = Mathf.Clamp(Vel, MinVel, MaxVel);
        switch (startDir)
        {
		case HMovDir.LEFT:
			vel *= -1;
			break;
		}
    }
	protected virtual void Start(){
		
	}

    protected virtual void FixedUpdate()
    {
		
        move();
       

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
	virtual public void move()
    {
		if (transform.position.x >= Limit) 
        {
			doSomeThingWhenPosIsRightLimit ();
        }
		else if(transform.position.x <= -Limit){
			doSomeThingWhenPosIsLeftLimit ();
		}

        Vector3 v = new Vector3(Vel * Time.fixedDeltaTime, 0, 0);
        transform.position += v;
    }

	public virtual void doSomeThingWhenPosIsLeftLimit(){
	
		Vel *= -1;

	
	}

	public virtual void doSomeThingWhenPosIsRightLimit(){

		Vel *= -1;


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
