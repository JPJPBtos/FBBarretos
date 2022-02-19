using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pontuacao : MonoBehaviour {

    public static int moedas;
    public Text txtMoedas;
	// Use this for initialization
	void Start () {
        moedas = 0;
	}
	
	// Update is called once per frame
	void Update () {
        txtMoedas.text = moedas.ToString();
	}
}
