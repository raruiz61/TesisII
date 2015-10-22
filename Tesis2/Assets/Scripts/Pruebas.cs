using UnityEngine;
using System.Collections;
using System;

public class Pruebas : MonoBehaviour {
	public DateTime inicio; 

	public DateTime final;
	// Use this for initialization
	void Start () {
		inicio = DateTime.Now;
		final = DateTime.Now;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void medirTiempo(){
		TimeSpan transcurrido = final.Subtract(inicio); 

		Debug.Log (transcurrido);
	}
}
