using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moeda : MonoBehaviour {

    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D colisao)
    {
      

    }

    void OnTriggerEnter2D(Collider2D colisao)
    {
        if (colisao.gameObject.tag == "Player")
        {
            pontuacao.moedas += 1;
            Destroy(this.gameObject);
        }
    }
}
