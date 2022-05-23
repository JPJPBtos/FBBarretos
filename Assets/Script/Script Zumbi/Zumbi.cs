using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zumbi : MonoBehaviour {

    private Rigidbody2D zumbiRb;
    private SpriteRenderer zumbiSr;
    public float velocidadeDireita;
    public float velocidadeEsquerda;
    private bool andarDireita = true;
	// Use this for initialization
	void Start () {

        zumbiRb = GetComponent<Rigidbody2D>();
        zumbiSr = GetComponent<SpriteRenderer>();

        
	}
	
	// Update is called once per frame
	void Update () {
       
        if (andarDireita == true)
        {
            zumbiSr.flipX = false;
            zumbiRb.velocity = new Vector2(velocidadeDireita, zumbiRb.velocity.y);
        }
        if(andarDireita == false)
        {
            zumbiSr.flipX = true;
            zumbiRb.velocity = new Vector2(velocidadeEsquerda, zumbiRb.velocity.y);
        }
	}

    private void OnCollisionEnter2D(Collision2D colisao){
		if(colisao.gameObject.tag == "espada")
		{
			Destroy(this.gameObject);
			pontuacao.moedas += 1;
		}
	}

    void OnTriggerEnter2D(Collider2D colisao)
    {
        if (colisao.gameObject.tag == "BalaRifle")
        {
            Destroy(this.gameObject);
        }
        if (colisao.gameObject.tag == "paredeDireita")
        {
            andarDireita = false; 
        }
        if (colisao.gameObject.tag == "paredeEsquerda")
        {
            andarDireita = true;
        }

        
    }
}
