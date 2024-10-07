using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    Rigidbody2D rig;
    public bool canjump;

    public float jumpForce;
    public bool isJump;
    public bool doubleJump;

    public AudioClip jump;
    AudioSource audioSource;

    public bool canPoeira;


    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Jump();

    }
    public void Jump()
    {
        if(Input.GetButtonDown("Jump")||canjump)
        {
            if(!isJump)
            {
                rig.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
                canPoeira = true;
                isJump = true;
                doubleJump = false;
                transform.GetComponent<Poeira>().Poeirao();

                
            }
            else
            {
                if(doubleJump == false)
                {
                    rig.AddForce(new Vector2(0,jumpForce), ForceMode2D.Impulse);
                    audioSource.PlayOneShot(jump);
                    doubleJump = true;
                    transform.GetComponent<Poeira>().Poeirao();
                }
            }

        }
        
    }
    public void CanJump()
    {
        canjump = true;
        Invoke("NoCanJump", 0.2f);
    }
    public void NoCanJump()
    {
        canjump = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            isJump = false;
        }
        if(collision.gameObject.tag == "Bomb")
        {
            rig.AddForce(new Vector2(0,10),ForceMode2D.Impulse);
            transform.GetComponent<CapsuleCollider2D>().enabled = false;
        }
    }

}
