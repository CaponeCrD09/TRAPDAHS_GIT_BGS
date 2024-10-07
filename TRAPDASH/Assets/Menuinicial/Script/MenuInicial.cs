using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayButton()
    {
        GameObject.Find("Player").GetComponent<PlayerMenager>().testando();
        SceneManager.LoadScene("ScenaTutoria");
    }
    public void QuitButton()
    {
        Application.Quit();
    }
    public void MenuInicialButton()
    {
        GameObject.Find("Player").GetComponent<PlayerMenager>().testando();
        SceneManager.LoadScene("MenuInicial");
    }
    public void Credts()
    {
        GameObject.Find("CanvasMenu").transform.Find("Panel_Credts").gameObject.SetActive(true);
    }
    public void NextCredits()
    {
        GameObject.Find("CanvasMenu").transform.Find("Panel_Credts").gameObject.SetActive(false);
    }
}
