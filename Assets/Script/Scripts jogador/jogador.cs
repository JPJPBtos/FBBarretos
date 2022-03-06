using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;


public class jogador : MonoBehaviour{

    private Rigidbody2D jogadorRb;
    public static SpriteRenderer jogadorSr;

    private BoxCollider2D jogadorCollider;
    public float vFrente;
	public float vTras;
	
    public Animator andar;
	public Animator espada;
	public BoxCollider2D espadaBc; 
	public static int facaN;
	public GameObject facaPrefab;
	public GameObject esphitPb;
	
    int estanoChao;
    bool colisaoParede;
    
   
    




    // Use this for initialization
    void Start () {

        jogadorRb = GetComponent<Rigidbody2D>();
        jogadorSr = GetComponent<SpriteRenderer>();
		jogadorCollider = GetComponent<BoxCollider2D>();

        

       
        
		
    }
	
	// Update is called once per frame
	void Update () {
	
        
        
/*
 if(jogadorSr.flipX == true && BtnTras.pressionando || Input.GetButton("Tras")){
                    andar.Play("Andar");
                    jogadorSr.flipX = false;
                    jogadorRb.velocity = new Vector2(vTras, jogadorRb.velocity.y);
                    
                    }else{
                       
                        andar.Play("Parado");
                        jogadorRb.velocity = new Vector2(0, jogadorRb.velocity.y);
                    }
            
            
            if(jogadorSr.flipX == false && BtnFrente.pressionando || Input.GetButton("Frente")){
                        andar.Play("Andar");
                        jogadorSr.flipX = true;
                        jogadorRb.velocity = new Vector2(vFrente, jogadorRb.velocity.y);
                    }else{
                        andar.Play("Parado");
                        jogadorRb.velocity = new Vector2(0, jogadorRb.velocity.y);
                    }*/
		
		Andar();

		if (Input.GetButtonDown ("Pular")) {
			Pular();
		}
		if (Input.GetButtonDown ("Bater")) {
			Bater();
		}
		if (Input.GetButtonDown ("Atirar")) {
			Atirar();
		}
        
    }

    public void Andar(){
        if(colisaoParede == false){
            if(BtnTras.pressionando || Input.GetButton("Tras")){
                andar.Play("Andar");
                jogadorSr.flipX = false;
                jogadorRb.velocity = new Vector2(vTras, jogadorRb.velocity.y);
            }else if(BtnFrente.pressionando || Input.GetButton("Frente")){
                andar.Play("Andar");
                jogadorSr.flipX = true;
                jogadorRb.velocity = new Vector2(vFrente, jogadorRb.velocity.y);
            }else{
                andar.Play("Parado");
                jogadorRb.velocity = new Vector2(0, jogadorRb.velocity.y);
            }
        }
        
        if(colisaoParede == true){
            switch(jogadorSr.flipX){
                case true:
                    if(BtnTras.pressionando || Input.GetButton("Tras")){
                        andar.Play("Andar");
                        jogadorSr.flipX = false;
                        jogadorRb.velocity = new Vector2(vTras, jogadorRb.velocity.y);
                    }
                    break;
                case false:
                    if(BtnFrente.pressionando || Input.GetButton("Frente")){
                        andar.Play("Andar");
                        jogadorSr.flipX = true;
                        jogadorRb.velocity = new Vector2(vFrente, jogadorRb.velocity.y);
                    }
                    break;
                default:
                    andar.Play("Parado");
                    jogadorRb.velocity = new Vector2(0, jogadorRb.velocity.y);
                    break;
            }
        }
    }
	
	public void Atirar(){
		if (facaN >= 1){
			Instantiate(facaPrefab, transform.position, transform.localRotation);
			facaN -= 1;
		}
	}

    public void Pular()
    {
        if (estanoChao == 1)
        {
                        
            andar.Play("Pular");
            jogadorRb.velocity = new Vector2(jogadorRb.velocity.x, 6);
            
        }
        estanoChao = 0;
    }
	
	public void Bater()
	{
		Instantiate (esphitPb, new Vector3(transform.position.x + 1, transform.position.y, transform.position.z), transform.localRotation);
		//espada.Play("espadada");
		//espada.Play("esp");
	}

    private void OnCollisionEnter2D(Collision2D colisao)
    {
        
        if (colisao.gameObject.tag == "chao")
        {   
            estanoChao = 1;
            andar.Play("Andar");
        }

        if (colisao.gameObject.tag == "parede")
        {   
            colisaoParede = true; 
        }
       
        if (colisao.gameObject.CompareTag("parar"))
        {
            
            andar.Play("Pular");
            jogadorRb.velocity = new Vector2(0, jogadorRb.velocity.y);

        }

        if (colisao.gameObject.tag == "espinho" || colisao.gameObject.tag == "zumbi")
        {
            SceneManager.LoadScene("GameOver");
           
        }

       if(colisao.gameObject.tag == "Finish")
        {
            SceneManager.LoadScene("Passou");
        }

    }

    private void OnCollisionExit2D(Collision2D colisao)
    {
        if (colisao.gameObject.tag == "chao")
        {   
            estanoChao = 0;
            
        }
        if (colisao.gameObject.tag == "parede")
        {   
            colisaoParede = false;
            
        }
        
    }

    void OnTriggerEnter2D(Collider2D colisao)
    {
        if (colisao.gameObject.tag == "espinho")
        {
            SceneManager.LoadScene("GameOver");
        }

        if(colisao.gameObject.tag == "facaItem"){
            facaN += 1;
        }
    }
}
