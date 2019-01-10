using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public float speed;
    private Vector2 rotation;
    private Rigidbody ball;

    // Start is called before the first frame update
    void Start()
    {
        ball = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        Physics.Raycast(transform.position, new Vector2(Mathf.Abs(Mathf.PingPong(Time.time * speed, 1f) - 1f), Mathf.PingPong(Time.time * speed, 1f)));
        Debug.DrawRay(transform.position, new Vector2(Mathf.Abs(Mathf.PingPong(Time.time * speed, 1f) - 1f), Mathf.PingPong(Time.time * speed, 1f)) * 10f, Color.blue);
    }
}
