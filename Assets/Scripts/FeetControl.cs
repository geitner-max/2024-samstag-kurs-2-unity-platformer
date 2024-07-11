using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeetControl : MonoBehaviour
{
    public LayerMask platforms;
    private bool grounded;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(GetComponent<Transform>().position.y);
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other);
        if (other.gameObject.layer == platforms) grounded = true;
    }

    void OnTriggerExit(Collider other)
    {
         Debug.Log(other);
        if (other.gameObject.layer == platforms) grounded = false;
    }

    public bool IsGrounded() { return grounded; }
}
