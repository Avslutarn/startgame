using UnityEngine;
using System.Collections;

public class RopeMovement : MonoBehaviour {
    public enum mouseButton { left = 0, right = 1}
    public float force;
    public mouseButton button;
    Rigidbody rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown((int)button))
        {

            RaycastHit hit;
            var cam = Camera.main.transform;
            Ray ray = new Ray(cam.position, cam.forward);

            if (Physics.Raycast(ray.origin, ray.direction, out hit))
            {
                if (hit.collider.tag != "player")
                {
                    var direction = hit.point - rb.position;
                    direction = direction / direction.magnitude;
                    rb.AddForce(direction * force);
                }
            }
        }
    }
}
