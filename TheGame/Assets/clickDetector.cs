using UnityEngine;
using System.Collections;

public class clickDetector : MonoBehaviour {

    private BoxCollider kuben;
    private Rigidbody rb;

    // Use this for initialization
    void Start () {
        //rb = GetComponent

        rb = GetComponent<Rigidbody>();
        kuben = GetComponentInChildren<BoxCollider>();

        print("Click detector initialized!");
        Debug.Log("Click detector initialized -- debug!");
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetMouseButtonDown(0))
        {

            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray.origin, ray.direction, out hit))
            {
                //
                // Kolla om vi träffar kuben
                //
                if (hit.collider.Equals(kuben))
                {
                    rb.AddForce(Vector3.back * 400);
                    Debug.Log("COLLISION!!!");
                }
            }
        }
	}
}
