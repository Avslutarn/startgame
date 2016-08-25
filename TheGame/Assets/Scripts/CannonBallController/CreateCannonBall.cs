using UnityEngine;
using System.Collections;

public class CreateCannonBall : MonoBehaviour
{

    public Rigidbody ball;
    public float force;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Ball fired");
            FireBall();
        }

    }

    void FireBall()
    {
        var trans = GetComponent<Transform>();

        Rigidbody ballClone = (Rigidbody)Instantiate(
            ball,
            trans.position,
            trans.rotation
        );

        ballClone.AddRelativeForce(Vector3.forward * force);
    }
}
