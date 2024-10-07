using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detonador : MonoBehaviour
{
    public bool destuir;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.Find("Bomb_0").transform.GetComponent<Bomb>().podeDestruir == true)
        {
            Destroy(gameObject,0.7f);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            transform.Find("Bomb_0").transform.GetComponent<Bomb>().canBomb = true;
            
        }
    }
}
