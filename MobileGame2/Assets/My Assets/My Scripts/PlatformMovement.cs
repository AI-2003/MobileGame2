using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public Rigidbody platform;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        platform.velocity = new Vector2(0f, speed);
    }

    // Update is called once per frame
    void Update()
    {
        if(platform.position.y > 3.5f)
        {
            platform.velocity = new Vector2(0f, -speed);
        }

        if (platform.position.y < -3.5f)
        {
            platform.velocity = new Vector2(0f, speed);
        }
    }
}
