using UnityEngine;
using System.Collections;

public class MeleeRangeBox : MonoBehaviour {

    private EnemyMelee myEnemyMelee;

	// Use this for initialization
	void Start () {
        myEnemyMelee = GetComponentInParent<EnemyMelee>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
            myEnemyMelee.PlayerEnterRange();
        }
    }
}
