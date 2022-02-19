using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class espinhoL : MonoBehaviour {

    private Rigidbody2D espinhoRb;
    public float velocidade;
    public float y;
    public Transform espinho1;
    

    
    [SerializeField]
    private float minX;
    
    
    
    // Use this for initialization
    void Start () {

        espinhoRb = GetComponent<Rigidbody2D>();
        //espinho1.position = Vector3.Lerp(espinho1.position, new Vector3(minX, espinho1.position.y, espinho1.position.z), Time.deltaTime);
	}
	
	// Update is called once per frame
	void Update () {

        espinhoRb.velocity = new Vector2(velocidade, y);
        
        //espinho1.position = Vector3.Lerp(espinho1.position, new Vector3(minX, espinho1.position.y, espinho1.position.z), Time.deltaTime);

       
    }
}
