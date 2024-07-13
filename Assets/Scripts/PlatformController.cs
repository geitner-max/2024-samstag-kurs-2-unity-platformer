using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject platform;
    void Start()
    {
        Instantiate(platform, new Vector2(0, -2), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
