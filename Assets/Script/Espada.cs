using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espada : MonoBehaviour {

	//private Rigidbody2D espadaRb;
	public Transform jogador;

	// Use this for initialization
	void Start () {
		//espadaRb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.position = new Vector3(jogador.position.x, jogador.position.y, transform.position.z);
	
	}

	private void OnCollisionEnter2D(Collision2D colisao)
	{
		if (colisao.gameObject.tag == "zumbi") {
			
		}
	}
}
