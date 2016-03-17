using UnityEngine;
using System.Collections;
using System;

public class PlantedSeed : MonoBehaviour {

    public float evolutionTimeStart;
    private float evolutionTime;
    private bool canGrow;
    private int evolutionState;
	// Use this for initialization
	void Start () {
        evolutionTime = evolutionTimeStart;
        canGrow = true;
        evolutionState = 0;
	}
	
	// Update is called once per frame
    void Update()
    {
        if (canGrow)
        {
            Growing();
        }
    }

    void Growing()
    {      
        evolutionTime -= Time.deltaTime;
        Debug.Log(evolutionTime);
        if (evolutionTime <= 0)
        {
            this.transform.GetChild(evolutionState).gameObject.SetActive(false);
            this.transform.GetChild(evolutionState+1).gameObject.SetActive(true);
            if (evolutionState < 3)
            {
                evolutionState += 1;
                evolutionTime = evolutionTimeStart;
            }
        }

    }

    void NeedWater()
    {
    }
}
