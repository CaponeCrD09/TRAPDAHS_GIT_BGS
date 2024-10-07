using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPlayer : MonoBehaviour
{
    GameObject chef;
    // Start is called before the first frame update
    void Start()
    {
        chef = GameObject.FindWithTag("Chef").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void End()
    {
        chef.transform.Find("Canvas").transform.Find("end").gameObject.SetActive(true);
        transform.Find("CanvasPlayer").transform.Find("PanelDialog").gameObject.SetActive(false);
    }
}
