using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    private static Rigidbody myRigidBody;

    public KeyCode keyForward, keyLeft, keyRight, keyDown;
    private bool pressForward, pressLeft, pressRight, pressDown;
    private bool isMoving;

    public float movementSpeed, turnSpeed;

    public enum MoveDirection { up = 0, upRight = 45, upLeft = 315, down = 180, downRight = 135, downLeft = 225, right = 90, left = 270 };

    MoveDirection myMoveDirection;

	// Use this for initialization
	void Start () 
    {
        myRigidBody = GetComponent<Rigidbody>();

        pressForward = pressLeft = pressRight = pressDown = false;
	}

    void FixedUpdate()
    {
        HandleInput();
        HandleMovement();
    }

	void Update () 
    {
        CheckInput();
	}

    void CheckInput()
    {
        if (Input.GetKey(keyForward))
        {
            pressForward = true;
        }
        else pressForward = false;

        if (Input.GetKey(keyLeft))
        {
            pressLeft= true;
        }
        else pressLeft = false;

        if (Input.GetKey(keyRight))
        {
            pressRight = true;
        }
        else pressRight = false;

        if (Input.GetKey(keyDown))
        {
            pressDown = true;
        }
        else pressDown = false;
    }
    void HandleInput()
    {
        
        #region Wasd + rotation
        /**
        if (pressForward)
        {
            //Go forward
            myRigidBody.velocity = gameObject.transform.forward * movementSpeed;
        }
        else myRigidBody.velocity = Vector3.zero;

        if (pressLeft)
        {
            //Turn left
            transform.Rotate(0, -turnSpeed * Time.deltaTime, 0);
        }

        if (pressRight)
        {
            //Turn right
            transform.Rotate(0, turnSpeed * Time.deltaTime, 0);
         
        }
         **/
        
        #endregion
        isMoving = true;
        if (pressForward)
        {
            //  movedirection 1,2 of 3
            if (pressRight)
            {
                myMoveDirection = MoveDirection.upRight;
            }
            else if (pressLeft)
            {
                myMoveDirection = MoveDirection.upLeft;
            }
            else myMoveDirection = MoveDirection.up;
        }
        else if (pressDown)
        {
            // movedirection 4,5,6
            if (pressRight)
            {
                myMoveDirection = MoveDirection.downRight;
            }
            else if (pressLeft)
            {
                myMoveDirection = MoveDirection.downLeft;
            }
            else myMoveDirection = MoveDirection.down;
        }
        else if (pressRight)
        {
            myMoveDirection = MoveDirection.right;
        }
        else if (pressLeft)
        {
            myMoveDirection = MoveDirection.left;
        }
        else
        {
            //Not moving
            isMoving = false;
        }

    }
    void HandleMovement()
    {
        //Set movement direction
        transform.eulerAngles = new Vector3(0, (float)myMoveDirection, 0);

        //Move forward
        if (isMoving)
        {
            myRigidBody.velocity = transform.forward * movementSpeed;
        }
        else
        {
            myRigidBody.velocity = Vector3.zero;
        }
    }

    public float GetSpeed
    {
        get
        {
            return myRigidBody.velocity.magnitude;
        }

    }
}
