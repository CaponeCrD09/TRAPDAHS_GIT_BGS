using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Animacao : MonoBehaviour
{
    Animator anim;
    AudioSource audioSource;

    public AudioClip walk;
    public AudioClip jump;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<PlayerJump>().isJump == false && GetComponent<PlayerMove>().horizontal != 0)
        {
            anim.SetInteger("transition", 1);
        }
        else if (GetComponent<PlayerJump>().isJump == true)
        {

            anim.SetInteger("transition", 3);
        }
        else
        {
            anim.SetInteger("transition", 0);
        }

        if(GetComponent<PlayerMenager>().life <= 0)
        {
            anim.SetInteger("transition", 0);
        }
    }
    public void SomJump()
    {
        audioSource.PlayOneShot(jump);
    }
    public void WalkSource()
    {
        audioSource.PlayOneShot(walk);
    }
}
