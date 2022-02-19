using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Faca : MonoBehaviour {

	private Rigidbody2D facaRb;
	
    public float velocidade;
	// Use this for initialization
	void Start () {
		facaRb = GetComponent<Rigidbody2D>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
		facaRb.velocity = new Vector2(velocidade, 0);
	
	}
	
	void OnTriggerEnter2D(Collider2D colisao)
    {
        if (colisao.gameObject.tag == "zumbi")
        {
			jogador.facaN += 1;
            Destroy(this.gameObject);
        }

		
    }
}
