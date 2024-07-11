using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    public float speed;
    public float jumpPower;
    public FeetControl feet;
    Rigidbody2D body;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.velocity.y);
        if (Input.GetKey(KeyCode.Space) && feet.IsGrounded()) body.velocity = new Vector2(body.velocity.x, jumpPower);
    }
}
