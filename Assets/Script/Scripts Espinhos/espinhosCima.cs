using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class espinhosCima : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D colisao)
    {
        if (colisao.gameObject.tag == "chao")
        {
            Destroy(this.gameObject);
        }
    }
}
