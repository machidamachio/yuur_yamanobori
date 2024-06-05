using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float theta = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (-50.0f < theta)
            {
                transform.Rotate(new Vector3(-0.5f, 0, 0));
                theta += -0.5f;
            }
        }
        
        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (theta < 50.0f)
            {
                transform.Rotate(new Vector3(0.5f, 0, 0));
                theta += 0.5f;
            }
        }
    }
}
