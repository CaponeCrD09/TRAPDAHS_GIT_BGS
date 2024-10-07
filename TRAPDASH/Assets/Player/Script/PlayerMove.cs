using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    public FixedJoystick moverH;
    Rigidbody2D rig;

    public float speed;
    public float horizontal;

    public bool direita;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    public void Move()
    {
        horizontal = Input.GetAxis("Horizontal");
        //horizontal = moverH.Horizontal;
        rig.velocity = new Vector2 (horizontal * speed, rig.velocity.y);

        if(horizontal < 0 )
        {
            transform.localScale = new Vector3(-9, 9, 9);
            direita = false;
        }
        if(horizontal > 0 )
        {
            transform.localScale = new Vector3(9, 9, 9);
            direita = true;
        }

    }



}
