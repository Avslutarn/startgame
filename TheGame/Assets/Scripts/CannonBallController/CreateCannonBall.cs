using UnityEngine;
using System.Collections;

public class createCannonBall : MonoBehaviour {

    public Rigidbody ball;
    public float force = 10f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetButtonDown("Fire1"))
        {
            FireBall();
        }
	
	}

    void FireBall()
    {
        GameObject gunNeck2 = GameObject.Find("GunNeck2");
        Vector3 gunNeck2Front = gunNeck2.transform.position;
        Debug.Log(gunNeck2Front);
        Debug.Log(gunNeck2.);
        Rigidbody ballClone = (Rigidbody) Instantiate(ball, gunNeck2Front, gunNeck2.transform.rotation);
        ballClone.AddForce(gunNeck2.transform.position * force);
    }
}
