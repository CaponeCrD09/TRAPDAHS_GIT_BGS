using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    Animator anim;
    public AudioClip spickClip;
    AudioSource spickSource;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        spickSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag =="Player")
        {
            anim.SetInteger("transition", 1);
            spickSource.PlayOneShot(spickClip);
        }
    }
}
