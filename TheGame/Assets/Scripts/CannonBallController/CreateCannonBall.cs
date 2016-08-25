using UnityEngine;
using System.Collections;

public class CreateCannonBall : MonoBehaviour {

    public Rigidbody ball;
    public float force;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Ball fired");
            FireBall();
        }
	
	}

    void FireBall()
    {
        GameObject KanonMynning = GameObject.Find("KanonMynning");
        GameObject GunNeck2 = GameObject.Find("GunNeck2");

        Rigidbody ballClone = (Rigidbody) Instantiate(
            ball, 
            KanonMynning.transform.position, 
            GunNeck2.transform.rotation
        );

        ballClone.transform.rotation = GunNeck2.transform.rotation;

        ballClone.AddForce(Vector3.forward * force * Time.deltaTime);
    }
}
