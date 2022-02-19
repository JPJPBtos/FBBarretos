using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void fase1 (){
		SceneManager.LoadScene("Fase");
		Reiniciar.cFase = 1;
	}
	public void fase2 (){
		SceneManager.LoadScene("Fase2");
		Reiniciar.cFase = 2;
	}
	public void fase3 (){
		SceneManager.LoadScene("Fase3");
		Reiniciar.cFase = 3;
	}
	public void menu(){
		SceneManager.LoadScene("Menu");
	}

	public void reiniciar(){
		if(Reiniciar.cFase == 1){
			fase1();
		}
		if(Reiniciar.cFase == 2){
			fase2();
		}
	}

	public void proximaF(){
		if(Reiniciar.cFase == 1){
			fase2();
		}
	}

	
}
