using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimCamera : MonoBehaviour
{
    Animator anim;
    public bool canShake;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {
       if(canShake)
        {
            anim.SetInteger("transition", 1);
            Invoke("NO", 0.09f);
        }
    }
    public void NO()
    {
        canShake = false;
        anim.SetInteger("transition", 0);
    }
}
