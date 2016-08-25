using UnityEngine;
using System.Collections;

public class TurnHorizontally : MonoBehaviour
{

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
        trans.Rotate(Vector3.up * Input.GetAxis("Mouse X") * Time.deltaTime * speed);
    }
}
