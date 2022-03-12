using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Faca : MonoBehaviour {

	private Rigidbody2D facaRb;
	private SpriteRenderer facaSr;
	
    public float velocidadeDireita;
	public float velocidadeEsquerda;
	// Use this for initialization
	void Start () {
		facaRb = GetComponent<Rigidbody2D>();
		facaSr = GetComponent<SpriteRenderer>();
		if (jogador.jogadorSr.flipX==true){	
			facaSr.flipX = false;
		    facaRb.velocity = new Vector2(velocidadeDireita, 0);}
		else
		{
			facaSr.flipX = true;
			facaRb.velocity = new Vector2(velocidadeEsquerda, 0);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
		
	
	}
	
	void OnTriggerEnter2D(Collider2D colisao)
    {
        if (colisao.gameObject.tag == "zumbi")
        {
			jogador.facaN += 1;
            Destroy(this.gameObject);
        }
    }

	void OnBecameInvisible() {
        Destroy(this.gameObject);
    }
}
