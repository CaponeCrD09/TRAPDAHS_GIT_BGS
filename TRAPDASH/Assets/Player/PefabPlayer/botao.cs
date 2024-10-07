using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class botao : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject player;
    // Start is called before the first frame update
    public void OnPointerDown(PointerEventData eventData)
    {
        player.GetComponent<PlayerJump>().CanJump();
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("Bot�o Solto!");
        // Coloque aqui o que voc� quer que aconte�a quando o bot�o for solto
    }

}
