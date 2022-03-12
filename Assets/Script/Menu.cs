using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Menu : MonoBehaviour {

	public int fase = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void fase1 (){
		SceneManager.LoadScene("Fase");
		fase = 1;
	}
	public void fase2 (){
		SceneManager.LoadScene("Fase2");
		fase = 2;
	}
	public void fase3 (){
		SceneManager.LoadScene("Fase3");
		fase = 3;
	}
	public void menu(){
		SceneManager.LoadScene("Menu");
	}

	public void reiniciar(){
		if(fase == 1){
			fase1();
		}
		if(fase == 2){
			fase2();
		}
	}

	public void proximaF(){
		if(fase == 1){
			fase2();
		}
	}

	
}
