using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorTransitioner : MonoBehaviour
{
    public List<Transform> front;
    public GameObject background;

    public bool isText;


    public Gradient frontColors;
    public Gradient backgroundColors;

    public float speed;

    void Start()
    {
        if (!(DataBridge.timePassed > 0f))
        {
            DataBridge.timePassed = 0f;
        }
    }

    void Update()
    {
        background.GetComponent<Camera>().backgroundColor = backgroundColors.Evaluate(Mathf.PingPong(Time.time * speed, 1));

        foreach (Transform item in front)
        {

            if (isText)
            {
                item.GetComponent<Text>().color = frontColors.Evaluate(Mathf.PingPong(Time.time * speed, 1));
            }
            else
            {
                item.GetComponent<Renderer>().material.color = frontColors.Evaluate(Mathf.PingPong(Time.time * speed, 1));
            }
        }
    }
}