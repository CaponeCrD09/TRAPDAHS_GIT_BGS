using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LeftRigth : MonoBehaviour
{
    public float speed;
    public bool right;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (right)
        {
            transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
            if (transform.position.x >= 9)
            {
                right = false;
            }
        }
        else
        {
            transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
            {
                if (transform.position.x <= -15)
                {
                    right = true;
                    
                }
            }
        }
    }

}
