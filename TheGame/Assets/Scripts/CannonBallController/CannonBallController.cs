using UnityEngine;
using System.Collections;

public class CannonBallController : MonoBehaviour {

    public float initialForce = 1000;

    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = this.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

	}

    void PushBall(float force)
    {
        rb.AddForce(Vector3.forward * force);
    }
}
