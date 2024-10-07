using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public float speed;
    public float starX;
    // Start is called before the first frame update
    void Start()
    {
        starX = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x >= -48)
        {
            transform.position = new Vector2(transform.position.x -speed * Time.deltaTime,transform.position.y);
        }
        else if(transform.position.x <= -48)
        {
            transform.position = new Vector2(starX,transform.position.y);
        }
    }
}
