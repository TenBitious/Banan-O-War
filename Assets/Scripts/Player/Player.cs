using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    private static Player instance = null;

    private static PlayerMovement myPlayerMovement;
    private static Transform myTransform;
    
    public static Player Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Player();
            }
            return instance;
        }
    }

	// Use this for initialization
	void Start () 
    {
        myPlayerMovement = GetComponent<PlayerMovement>();
        myTransform = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public static float GetCurrentSpeed
    {
        get
        {
            return myPlayerMovement.GetSpeed;
        }
    }
    public static Vector3 GetCurrentPosition
    {
        get
        {
            return myTransform.position;
        }
    }
}
