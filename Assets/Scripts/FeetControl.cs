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

    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (platforms == (1 << other.gameObject.layer))
        {
            grounded = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (platforms == (1 << other.gameObject.layer)) grounded = false;
    }

    public bool IsGrounded() { return grounded; }
}
