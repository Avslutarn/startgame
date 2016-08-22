using UnityEngine;
using System.Collections;

public class RocketController : MonoBehaviour {

    public int roll;
    public int elevation;

    // Use this for initialization
    void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(Vector3.right * elevation);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(Vector3.left * elevation);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * roll);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.back * roll);
        }
    }
}
