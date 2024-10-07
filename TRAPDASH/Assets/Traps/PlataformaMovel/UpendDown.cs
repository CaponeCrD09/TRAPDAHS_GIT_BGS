using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpendDown : MonoBehaviour
{
    public float speed;
    public bool canDown;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            if(canDown )
            {
                transform.position = new Vector2(transform.position.x, transform.position.y + speed * Time.deltaTime);

                if (transform.position.y >= 7)
                {
                    canDown = false; 
                }


            }
            if (canDown == false)
            {
                transform.position = new Vector2(transform.position.x,transform.position.y - speed * Time.deltaTime);

            if (transform.position.y <= -7)
            {
                canDown = true;
            }
        }

        

    }
}
