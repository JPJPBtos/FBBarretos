using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

    private float maxX = 96;
    
    public Transform jogador;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.position = new Vector3(Mathf.Clamp(jogador.position.x, 0, maxX ), Mathf.Clamp(jogador.position.y, 0, 0), transform.position.z);
	}
}
