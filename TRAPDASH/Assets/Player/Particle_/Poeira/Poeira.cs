using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poeira : MonoBehaviour
{
    public GameObject poeira;
    public Transform poeiraPoint;
    public bool canPoeira;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      // if (transform.GetComponent<PlayerJump>().canPoeira == true)
        //{
        //    Instantiate(poeira,poeiraPoint.transform.position,poeiraPoint.transform.rotation);
        //}
    }
    public void Poeirao()
    {

            Instantiate(poeira, poeiraPoint.transform.position, poeiraPoint.transform.rotation);
        
    }
}
