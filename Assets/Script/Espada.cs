using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espada : MonoBehaviour {

	//private Rigidbody2D espadaRb;
	public Transform jogador1;

	private SpriteRenderer rifleSr;
	
	
	// Use this for initialization
	void Start () {
		//espadaRb = GetComponent<Rigidbody2D>();
		rifleSr = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		
	
		
		if (jogador.jogadorSr.flipX==true){	
			rifleSr.flipX = false;
		    transform.position = new Vector3(jogador1.position.x + (float)0.3, jogador1.position.y - (float)0.200,
		 	transform.position.z);
		}
		else
		{
			rifleSr.flipX = true;
			transform.position = new Vector3(jogador1.position.x - (float)0.3, jogador1.position.y - (float)0.200,
		 	transform.position.z);
			
		}
	}

	private void OnCollisionEnter2D(Collision2D colisao)
	{
		
	}
}
