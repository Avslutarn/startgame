using UnityEngine;
using System.Collections;

public class AttachHand : MonoBehaviour
{
    public RopeMovement.mouseButton button;
    bool holding = false;
    Rigidbody rb;
    Vector3 holdPosition;

    // Use this for initialization
    void Start()
    {
        holdPosition = GetComponent<Transform>().position;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (holding)
        {
            if (!Input.GetMouseButton((int)button))
            {
                rb.constraints = RigidbodyConstraints.None;
                holding = false;
            }
            else
            {
                GetComponent<Transform>().position = holdPosition;
            }
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.GetComponent<Transform>().tag != "Player" && Input.GetMouseButton((int)button))
        {
            holdPosition = GetComponent<Transform>().position;
            rb.constraints = RigidbodyConstraints.FreezeAll;
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            holding = true;
        }
    }
}
