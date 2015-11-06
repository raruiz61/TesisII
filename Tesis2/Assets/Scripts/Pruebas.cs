using UnityEngine;
using System.Collections;
using System;

public class Pruebas : MonoBehaviour {
	public DateTime inicio; 

	public DateTime final;

	public int participante;
	public string  ruta;
	public int numLugares;
	public string tiempo;


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

		tiempo = transcurrido.ToString();
	}

	public string recolectar(){
		string texto = "";
		ruta = GameObject.Find ("Rutas").GetComponent<Ruta> ().determinarRuta();
		numLugares = GameObject.Find ("Player").GetComponent<Mirar> ().vio;

		texto = "Participante: " + participante + " \n" + 
			"Ruta: " + ruta + " \n" +
			"Tiempo: " + tiempo + " \n" +
			"Lugares: " + numLugares;

		return texto;
	}
}
