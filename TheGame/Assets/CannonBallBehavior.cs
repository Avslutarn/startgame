using UnityEngine;
using System.Collections;

public class CannonBallBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Collision!");
        if (col.gameObject.name == "DaDuck")
        {
            Destroy(col.gameObject);
        }
    }
}
