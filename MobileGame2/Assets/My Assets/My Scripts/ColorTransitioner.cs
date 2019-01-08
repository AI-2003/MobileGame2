using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorTransitioner : MonoBehaviour
{
    public GameObject front;
    public GameObject background;

    public Gradient frontColors;
    public Gradient backgroundColors;

    public float speed;

    void Start()
    {

    }

    void Update()
    {
        front.GetComponent<Renderer>().material.color = frontColors.Evaluate(Mathf.PingPong(Time.time * speed,1));
        background.GetComponent<Camera>().backgroundColor = backgroundColors.Evaluate(Mathf.PingPong(Time.time * speed, 1));
    }
}