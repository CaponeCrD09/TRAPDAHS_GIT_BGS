using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class PlayerMenager : MonoBehaviour
{
    public int life;
    public Transform playerSpawn;
    TextMeshProUGUI textLife;

    // Start is called before the first frame update
    private void Awake()
    {
        life = PlayerPrefs.GetInt("teste");

    }
    public void testando()
    {
        PlayerPrefs.SetInt("teste", life = 20);
    }
    void Start()
    {
        Debug.Log(PlayerPrefs.GetInt("teste"));
        textLife = transform.Find("CanvasPlayer").transform.Find("PanelLife").transform.Find("Life").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Fire1") > 0 )
        {
            PlayerPrefs.SetInt("teste", 20);
            SceneManager.LoadScene("MenuInicial");
        }
        textLife.text = life.ToString();
        if (life <= 0)
        {
            transform.Find("CanvasPlayer").transform.Find("PanelGame_Over").gameObject.SetActive(true);
            transform.GetComponent<PlayerMove>().enabled = false;
            StartCoroutine(PlayerDeath());

        }
    }
    public void DialogBack()
    {
        transform.Find("CanvasPlayer").transform.Find("PanelPhone").gameObject.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag =="Enemy")
        {
            if(life > 0)
            {
                life--;
                transform.gameObject.GetComponent<SpriteRenderer>().enabled = false;
                StartCoroutine(PlayerDeath());
            }

        }
        if(collision.gameObject.tag == "TutorialJump")
        {
            SceneManager.LoadScene("TutorialJump");
        }
        if (collision.gameObject.tag == "Scena01")
        {
            Debug.Log("Mudou?");
            PlayerPrefs.SetInt("teste",life);
            SceneManager.LoadScene("Scena01");
            transform.Find("CanvasPlayer").transform.Find("Panel_Loading").gameObject.SetActive(true);
        }
        if (collision.gameObject.tag == "Scena02")
        {
            PlayerPrefs.SetInt("teste", life);
            transform.Find("CanvasPlayer").transform.Find("Panel_Loading").gameObject.SetActive(true);
            SceneManager.LoadScene("Scena02");
        }
        if (collision.gameObject.tag == "Scena03")
        {
            PlayerPrefs.SetInt("teste", life);
            transform.Find("CanvasPlayer").transform.Find("Panel_Loading").gameObject.SetActive(true);
            SceneManager.LoadScene("Scena03");
        }
        if (collision.gameObject.tag == "Scena04")
        {
            PlayerPrefs.SetInt("teste", life);
            transform.Find("CanvasPlayer").transform.Find("Panel_Loading").gameObject.SetActive(true);
            SceneManager.LoadScene("Scena04");
        }
        if (collision.gameObject.tag == "Scena05")
        {
            PlayerPrefs.SetInt("teste", life);
            transform.Find("CanvasPlayer").transform.Find("Panel_Loading").gameObject.SetActive(true);
            SceneManager.LoadScene("Scena05");
        }
        if (collision.gameObject.tag == "Scena06")
        {
            PlayerPrefs.SetInt("teste", life);
            transform.Find("CanvasPlayer").transform.Find("Panel_Loading").gameObject.SetActive(true);
            SceneManager.LoadScene("Scena06");
        }
        if (collision.gameObject.tag == "Scena07")
        {
            PlayerPrefs.SetInt("teste", life);
            transform.Find("CanvasPlayer").transform.Find("Panel_Loading").gameObject.SetActive(true);
            SceneManager.LoadScene("Scena07");
        }
        if (collision.gameObject.tag == "Scena08")
        {
            PlayerPrefs.SetInt("teste", life);
            transform.Find("CanvasPlayer").transform.Find("Panel_Loading").gameObject.SetActive(true);
            SceneManager.LoadScene("Scena08");
        }
        if (collision.gameObject.tag == "Scena09")
        {
            PlayerPrefs.SetInt("teste", life);
            transform.Find("CanvasPlayer").transform.Find("Panel_Loading").gameObject.SetActive(true);
            SceneManager.LoadScene("Scena09");
        }
        if (collision.gameObject.tag == "ScenaFinal")
        {
            PlayerPrefs.SetInt("teste", life);
            transform.Find("CanvasPlayer").transform.Find("Panel_Loading").gameObject.SetActive(true);
            SceneManager.LoadScene("ScenaFinal");
        }
    }
    IEnumerator PlayerDeath()
    {
        yield return new WaitForSeconds(1);
        transform.position = playerSpawn.position;
        transform.gameObject.GetComponent<SpriteRenderer>().enabled = true;
        transform.GetComponent<PlayerMove>().enabled = true;

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Dialogo")
        {
            MostrarDialogo.instance.MostraDialogo();
            Destroy(other.gameObject);
        }
        if (other.gameObject.name == "DialogoFinal")
        {
            MostrarDialogo.instance.MostraDialogoFinal();
            Destroy(other.gameObject);
        }
    }

}
