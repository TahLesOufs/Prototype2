using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteOutOfBounds : MonoBehaviour
{

    private float topBound = 30;
    private float lowerBound = -10;
    public GameObject player;
    public GameObject[] animalPrefabs;
    public SpawnManager spawnManager;



    // Start is called before the first frame update
    void Start()
    {
        spawnManager = GameObject.FindObjectOfType<SpawnManager>();
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        } else if (transform.position.z < lowerBound){
            Debug.Log("Game Over");
            spawnManager.Stop();
            Destroy(gameObject);
            Destroy(player);
            
            
            
         
    
        }
    }
}
