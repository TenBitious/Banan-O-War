using UnityEngine;
using System.Collections;

public class ThrowingBanana : MonoBehaviour {

    private Rigidbody myRigidbody;

    public float rotationSpeed;

	// Use this for initialization
	void Start () {
        myRigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void FixedUpdate()
    {
        //Rotate
        transform.Rotate(new Vector3(rotationSpeed, 0, 0));
    }

    public void SetSpeed(float cSpeed)
    {
        Debug.Log("Banana speed:"+cSpeed);
        myRigidbody.velocity =  new Vector3(0,0,cSpeed);
    }
}
