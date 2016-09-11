using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class CameraPosition : MonoBehaviour {

    public float x;
    public float y;
    public float z;
    Transform trans;
    Transform playerTrans;
	// Use this for initialization
	void Start () {
        trans = GetComponent<Transform>();
        playerTrans = GameObject.FindWithTag("Player").GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void Update () {
        trans.position = playerTrans.position + new Vector3(x, y, z);
	}
}
