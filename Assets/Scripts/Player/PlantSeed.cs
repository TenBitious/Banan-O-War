using UnityEngine;
using System.Collections;

public class PlantSeed : MonoBehaviour {

    public KeyCode plantSeedKey;
    public PlantedSeed prefabPlantedSeed;
    public GameObject ground;

    private bool canPlant;
	// Use this for initialization
	void Start () {
        canPlant = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(plantSeedKey)&&canPlant)
        {
            PlantedSeed seed;
            seed = Instantiate(prefabPlantedSeed, new Vector3(transform.position.x,ground.transform.position.y,transform.position.z), transform.rotation) as PlantedSeed;
        }
        else if (Input.GetKeyDown(plantSeedKey) && !canPlant)
        {
            Debug.Log("You can not plant");
        }
	}

    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Seed")
        {
            canPlant = false;            
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Seed")
        {
            canPlant = true;
        }
    }
}
