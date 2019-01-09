using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour
{

    private Transform colorController;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Began)
            {               
                SceneManager.LoadScene("Main");
            }
        }
        if (Input.GetButtonDown("Fire1"))
        {
            SceneManager.LoadScene("Main");
        }
    }
}
