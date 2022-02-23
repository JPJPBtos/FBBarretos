using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zumbi : MonoBehaviour {

    private Rigidbody2D zumbiRb;
    private SpriteRenderer zumbiSr;
    public float velocidade;
    public float velocidadeA;
    public float maxX;
    public float minX;
    private bool andar = true;
	// Use this for initialization
	void Start () {

        zumbiRb = GetComponent<Rigidbody2D>();
        zumbiSr = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        if(transform.position.x <= minX)
        {
            andar = true;
        }
        if(transform.position.x >= maxX)
        {
            andar = false;
        }
        if (andar == true)
        {
            zumbiSr.flipX = false;
            zumbiRb.velocity = new Vector2(velocidade, zumbiRb.velocity.y);
        }
        if(andar == false)
        {
            zumbiSr.flipX = true;
            zumbiRb.velocity = new Vector2(velocidadeA, zumbiRb.velocity.y);
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
        if (colisao.gameObject.tag == "faca")
        {
            Destroy(this.gameObject);
            
        }

        
    }
}
