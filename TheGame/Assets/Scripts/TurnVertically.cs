using UnityEngine;
using System.Collections;

public class TurnVertically : MonoBehaviour
{

    public float speed;
    public float minRotation;
    public float maxRotation;
    Transform trans;
    // Use this for initialization
    void Start()
    {
        trans = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        trans.Rotate(Vector3.left * Input.GetAxis("Mouse Y") * Time.deltaTime * speed);
        if (360 - trans.eulerAngles.x < minRotation || 360 - trans.eulerAngles.x > 300)
            trans.eulerAngles = new Vector3(360 - minRotation, trans.eulerAngles.y, trans.eulerAngles.z);
        else if (360 - trans.eulerAngles.x > maxRotation)
            trans.eulerAngles = new Vector3(360 - maxRotation, trans.eulerAngles.y, trans.eulerAngles.z);
    }
}
