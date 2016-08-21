using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour
{

    private bool hasJumped = false;
    private System.Diagnostics.Stopwatch elapsedTime;
    private Rigidbody rb;
    public int minWaitTime;
    public int maxWaitTime;
    public int jumpForce;

    // Use this for initialization
    void Start()
    {
        elapsedTime = new System.Diagnostics.Stopwatch();
        elapsedTime.Start();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasJumped && elapsedTime.ElapsedMilliseconds > minWaitTime)
        {
            Debug.Log("not jumped");
            if(Random.value > 0.99f || elapsedTime.ElapsedMilliseconds > maxWaitTime)
            {
                Debug.Log("jump!");
                rb.AddForce(Vector3.up * jumpForce);
                hasJumped = true;
            }
        }
    }
}
