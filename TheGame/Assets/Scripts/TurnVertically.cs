using UnityEngine;
using System.Collections;

public class TurnVertically : MonoBehaviour
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
        trans.Rotate(Vector3.left * Input.GetAxis("Mouse Y") * Time.deltaTime * speed);
        Debug.Log(trans.eulerAngles);
        if (trans.eulerAngles.x < 50)
            trans.eulerAngles = new Vector3(360, trans.eulerAngles.y, trans.eulerAngles.z);
        else if(trans.eulerAngles.x < 335)
            trans.eulerAngles = new Vector3(335, trans.eulerAngles.y, trans.eulerAngles.z);
    }
}
