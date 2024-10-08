using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piscar : MonoBehaviour
{

    bool aumentar = false;
    public float velocidade = 0.06f;

    void Start()
    {
        InvokeRepeating("PiscarAnimate", 0, Time.fixedDeltaTime);
    }

    void PiscarAnimate()
    {
        if (aumentar)
            transform.GetComponent<CanvasGroup>().alpha += velocidade;
        else
            transform.GetComponent<CanvasGroup>().alpha -= velocidade;

        if (transform.GetComponent<CanvasGroup>().alpha >= 1)
            aumentar = false;
        if (transform.GetComponent<CanvasGroup>().alpha <= 0)
            aumentar = true;

    }

}
