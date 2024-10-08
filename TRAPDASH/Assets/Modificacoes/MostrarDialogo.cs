using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MostrarDialogo : MonoBehaviour
{

    public float velocidade = 0.05f;
    public CanvasGroup dialogo;
    public CanvasGroup dialogoFinal;

    public static MostrarDialogo instance;
    private void Awake()
    {
        instance = this;
    }

    public void MostraDialogo()
    {
        StartCoroutine(Fade());
    }

    public void MostraDialogoFinal()
    {
        MostraDialogo();
        StartCoroutine(Aguardar());
        IEnumerator Aguardar()
        {
            yield return new WaitForSeconds(2.5f);
            while(dialogoFinal.alpha < 1)
            {
                dialogoFinal.alpha += velocidade;
            }
            yield return new WaitForSeconds(2f);
            SceneManager.LoadScene("MenuInicial");
        }
    }

    IEnumerator Fade()
    {
        
        while (dialogo.alpha < 1)
        {
            dialogo.alpha += velocidade;
            yield return null;
        }

        yield return new WaitForSeconds(2);

        while (dialogo.alpha > 0)
        {
            dialogo.alpha -= velocidade;
            yield return null;
        }
    }

}
