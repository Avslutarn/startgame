using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class CameraPosition : MonoBehaviour {

    Transform transform;
    Transform playerTrans;
	// Use this for initialization
	void Start () {
        transform = GetComponent<Transform>();
        playerTrans = GameObject.FindWithTag("Player").GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void Update () {
        transform.position = playerTrans.position + new Vector3(4, 2, 0);
	}
}
