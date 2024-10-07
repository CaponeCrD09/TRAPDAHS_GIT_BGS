using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class RockDestroy : MonoBehaviour
{
    public bool canDestroy;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {
        if(canDestroy)
        {
            transform.GetComponent<BoxCollider2D>().enabled = false;
            anim.SetInteger("transition", 1);
            Destroy(gameObject,0.7f);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="Player")
        {
            canDestroy = true;
        }
    }
}
