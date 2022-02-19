using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class espinhoC : MonoBehaviour {

    private Rigidbody2D espinhoRb;
    public float velocidade;
    
	// Use this for initialization
	void Start () {
        espinhoRb = GetComponent<Rigidbody2D>();
        espinhoRb.drag = velocidade;
        
	}
	
	// Update is called once per frame
	void Update () {
        
    }


}
