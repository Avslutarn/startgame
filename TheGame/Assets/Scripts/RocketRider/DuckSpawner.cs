using UnityEngine;
using System.Collections;

public class DuckSpawner : MonoBehaviour {

    public GameObject duckfab;
    public float spawnRate = 3f;
    public Transform[] spawnPoints;



	// Use this for initialization
	void Start () {
        InvokeRepeating("Spawn", spawnRate, spawnRate);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void Spawn ()
    {
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);

        Instantiate(duckfab, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }
}
