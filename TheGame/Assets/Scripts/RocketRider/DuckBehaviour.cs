using UnityEngine;
using System.Collections;

public class DuckBehaviour : MonoBehaviour {

    public float flyspeed;


	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += transform.right * Time.deltaTime * flyspeed;


	}
}
