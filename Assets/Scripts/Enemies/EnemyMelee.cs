using UnityEngine;
using System.Collections;

public class EnemyMelee : Enemy {

    private BoxCollider rangeTrigger;

    
	// Use this for initialization
    public override void Start()
    {
        base.Start();
	}
	
	// Update is called once per frame
    public override void Update() 
    {
        base.Update();
	}

    public override void FixedUpdate()
    {
        base.FixedUpdate();
    } 
    public override void HandleMovement()
    {
        base.HandleMovement();
    }

    public override void HandleAttacks()
    {
        base.HandleAttacks();
    }

    public override void PlayerEnterRange()
    {
        base.PlayerEnterRange();
        MyState = EnemyState.attack;
        StartAttack();

    }

    public override void StartAttack()
    {
        base.StartAttack();
        MyAttackState = AttackState.Start;
        //Start timer
        //Start animation
    }
    public override EnemyState MyState
    {
        get
        {
            return base.MyState;
        }
        set
        {
            base.MyState = value;
        }
    }
    public override AttackState MyAttackState
    {
        get
        {
            return base.MyAttackState;
        }
        set
        {
            base.MyAttackState = value;
        }
    }
}
