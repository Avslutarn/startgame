using UnityEngine;
using System.Collections;

public class RocketEngine : MonoBehaviour {

    private bool firing;
    public Rigidbody rb;
    public float RocketPower;
    
	// Use this for initialization
	void Start () {
        firing = false;
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(Vector3.forward * RocketPower);
        }

    }
}
