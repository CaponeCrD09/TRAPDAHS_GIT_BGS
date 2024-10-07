using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    Animator anim;
    Rigidbody2D rig;
    public bool canBomb;
    public bool podeDestruir;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canBomb)
        {
            rig.gravityScale = 1;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject)
        {
            GetComponent<AudioSource>().enabled = true;
            anim.SetInteger("transition", 1);
            transform.GetComponent<CircleCollider2D>().radius = 0.25f;
            podeDestruir = true;
            GameObject.Find("Main Camera").GetComponent<AnimCamera>().canShake = true;

        }
    }

    public void AltoDestruicao()
    {
        Destroy(gameObject,0.8f);
    }
}
