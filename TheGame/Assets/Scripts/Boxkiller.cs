using UnityEngine;
using System.Collections;

public class Boxkiller : MonoBehaviour {


    public int reloadTime;
    private bool reloading;

	// Use this for initialization
	void Start () {
        reloading = false;
	}
	
	// Update is called once per frame
	void Update () {
        RaycastHit hit;
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Physics.Raycast(ray, out hit);
            if (hit.collider.tag == "spelkub")
            {
                Destroy(hit.transform.gameObject);
            }
        }
	}
}
