using UnityEngine;
using System.Collections;

public class CameraRotation : MonoBehaviour {

    public float speed;
    Transform trans;
    // Use this for initialization
    void Start()
    {
        trans = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        trans.Rotate(Vector3.up * Input.GetAxis("Mouse X") * Time.deltaTime * speed, Space.World);
        trans.Rotate(Vector3.left * Input.GetAxis("Mouse Y") * Time.deltaTime * speed);
    }
}
