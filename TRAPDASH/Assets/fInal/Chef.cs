using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Chef : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            transform.Find("Canvas").transform.Find("Panel").gameObject.SetActive(true);
            player.GetComponent<PlayerMove>().speed = 0;
            player.transform.Find("CanvasPlayer").gameObject.SetActive(false);
        }
    }
    public void PlayerDialog()
    {
        player.transform.Find("CanvasPlayer").gameObject.SetActive(true);
        player.transform.Find("CanvasPlayer").transform.Find("PanelLife").gameObject.SetActive(false);
        player.transform.Find("CanvasPlayer").transform.Find("Fixed Joystick").gameObject.SetActive(false);
        player.transform.Find("CanvasPlayer").transform.Find("Jump").gameObject.SetActive(false);
        player.transform.Find("CanvasPlayer").transform.Find("PanelDialog").gameObject.SetActive(true);

        //desativat canvas do chaf

        transform.Find("Canvas").transform.Find("Panel").gameObject.SetActive(false);


    }
    public void Back()
    {
        SceneManager.LoadScene("MenuInicial");
    }
    
}
