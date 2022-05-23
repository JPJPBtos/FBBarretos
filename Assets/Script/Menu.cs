using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Menu : MonoBehaviour {

	public static int fase;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void fase1 (){
		SceneManager.LoadScene("Fase");
		fase = 1;
		jogador.facaN = 0;
	}
	public void fase2 (){
		SceneManager.LoadScene("Fase2");
		fase = 2;
		jogador.facaN = 0;
	}
	public void fase3 (){
		SceneManager.LoadScene("Fase3");
		fase = 3;
		jogador.facaN = 0;
	}
	public void fase4 (){
		SceneManager.LoadScene("Fase4");
		fase = 4;
		jogador.facaN = 0;
	}
	public void menu(){
		SceneManager.LoadScene("Menu");
	}

	public void reiniciar(){
		switch(fase){
			case 1:
				fase1();
				break;
			case 2:
				fase2();
				break;
			case 3:
				fase3();
				break;
			case 4:
				fase4();
				break;
			default:
				break;
		}
	}

	public void proximaF(){
		switch(fase){
			case 1:
				fase2();
				break;
			case 2:
				fase3();
				break;
			case 3:
				fase4();
				break;
			default:
				break;
		}
	}

	
}
