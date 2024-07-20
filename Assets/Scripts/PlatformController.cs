using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{

    public GameObject platform;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(platform, new Vector2(0, -2), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
