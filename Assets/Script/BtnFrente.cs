using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class BtnFrente : MonoBehaviour, IPointerDownHandler, IPointerUpHandler 
{

    public float botao;
    public float sensibilidade;
    public static bool pressionando;
 
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (pressionando)
        {
            botao += Time.deltaTime * sensibilidade;
        }
        else
        {
            botao -= Time.deltaTime * sensibilidade;
        }
        botao = Mathf.Clamp(botao, 0, 1);

       
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        pressionando = true;

    }

    public void OnPointerUp(PointerEventData eventData)
    {
        pressionando = false;
    }
}
