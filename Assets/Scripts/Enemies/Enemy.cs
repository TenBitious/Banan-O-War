using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {


    public float movementSpeed, rotationSpeed;
    public enum EnemyState { moving = 1, attack = 2, stunned = 3 };
    public enum AttackState { Start = 1, Damage = 2, End = 3 };
    
    EnemyState myState;
    AttackState myAttackState;

    private Rigidbody myRigidbody;
    private Transform myTransform;

    private GameObject focusObject;

    public float attackTimer, attackDamageTime;
    private float currentAttackTime;

    public virtual void Start() 
    {
        myTransform = GetComponent<Transform>();
        myRigidbody = GetComponent<Rigidbody>();

        //focusObject = Player.Instance.gameObject;
        focusObject = GameObject.FindGameObjectWithTag("Player");

        myState = EnemyState.moving;

        currentAttackTime = 0;
	}

    public virtual void FixedUpdate()
    {
        //Handle Movement
        HandleMovement();
        HandleAttacks();
    }
	public virtual void Update () 
    {
        HandleAttacks();
	}

    public virtual void  HandleMovement()
    {
        if (myState == EnemyState.moving)
        {
            //myTransform.rotation = Quaternion.Slerp(myTransform.rotation, Quaternion.LookRotation(focusObject.transform.position - myTransform.position), rotationSpeed * Time.deltaTime);

            Vector3 targetDir = focusObject.transform.position - myTransform.position;
            
            Quaternion rotation = Quaternion.LookRotation(targetDir);

            myTransform.rotation = rotation;
            myRigidbody.velocity = transform.forward * movementSpeed;
        }
    }

    public virtual void  HandleAttacks()
    {
        CurrentAttackTime += Time.deltaTime;
        if (MyAttackState == AttackState.Start && CurrentAttackTime >= attackDamageTime)
        {
            //Damage Player

        }
    }

    public virtual void PlayerEnterRange()
    {

    }

    public virtual void StartAttack()
    {

    }
    public virtual EnemyState MyState
    {
        get
        {
            return myState;
        }
        set
        {
            myState = value;
        }
    }
    public virtual AttackState MyAttackState
    {
        get
        {
            return myAttackState;
        }
        set
        {
            myAttackState = value;
        }
    }

    public float CurrentAttackTime
    {
        get { return currentAttackTime; }
        set { currentAttackTime = value; }
    }
}
