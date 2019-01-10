using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public Rigidbody platform;
    public Rigidbody character;
    public float speed;
    public bool ballLaunched = false;

    // Start is called before the first frame update
    void Start()
    {
        //Initial movement
        platform.velocity = new Vector2(0f, speed);
        character.velocity = new Vector2(0f, speed);
    }

    // Update is called once per frame
    void Update()
    {

        //Moves it up and down
        if(platform.position.y > 3.5f)
        {
            platform.velocity = new Vector2(0f, 0f);
            platform.position = new Vector2(-2.5f, 3.5f);
            
        }else if (platform.position.y < -3.5f)
        {
            platform.velocity = new Vector2(0f, 0f);
            platform.position = new Vector2(-2.5f, -3.5f);
        }

        if (!ballLaunched)
        {
            if (character.position.y > 3.5f)
            {
                character.velocity = new Vector2(0f, 0f);
                character.position = new Vector2(-2f, 3.5f);
            }
            else if (character.position.y < -3.5f)
            {
                character.velocity = new Vector2(0f, 0f);
                character.position = new Vector2(-2f, -3.5f);
            }

            if (platform.position.y == character.position.y && platform.position.y == 3.5f)
            {
                platform.velocity = new Vector2(0f, -speed);
                character.velocity = new Vector2(0f, -speed);
            }
            else if (platform.position.y == character.position.y && platform.position.y == -3.5f)
            {
                platform.velocity = new Vector2(0f, speed);
                character.velocity = new Vector2(0f, speed);
            }
        }
        else
        {
            platform.velocity = new Vector2(0f, 0f);
        }
    }
}
