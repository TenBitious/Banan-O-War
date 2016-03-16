using UnityEngine;
using System.Collections;

public class ThrowBanana : MonoBehaviour {

    public float throwSpeed;

    public KeyCode keyThrow;

    public ThrowingBanana prefabThrowingBanana;

	// Use this for initialization
	void Start () 
    {
	}
	
	// Update is called once per frame
	void FixedUpdate () 
    {
	    //If button pressed, spawn banana
        if (Input.GetKeyDown(keyThrow))
        {
            ThrowingBanana banana;
            banana = Instantiate(prefabThrowingBanana, transform.position, transform.rotation) as ThrowingBanana;
            banana.GetComponent<Rigidbody>().velocity = banana.transform.forward * throwSpeed;
            //Intiatataete throwingBanana prefab
        }
	}
}
