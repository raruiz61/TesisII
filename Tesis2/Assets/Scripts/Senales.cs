using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class Senales : MonoBehaviour {

	public GameObject calle;
	public GameObject carrera;
	public GameObject walk;
	public GameObject alto;
	public GameObject bus;
	public GameObject ruta;
	public GameObject camino;
	public GameObject lugar;

	// Use this for initialization
	void Start () {
		walk.GetComponent<Image> ().enabled = false;
		bus.GetComponent<Image> ().enabled = false;
		alto.GetComponent<Image> ().enabled = true;
		//cambiarUbicacion ();

		cambiarRuta("Ruta: 56A");

	}
	
	// Update is called once per frame
	void Update () {
		cambiarRuta(GameObject.Find("Rutas").GetComponent<Ruta>().determinarRuta());

	}

	public void cambiarUbicacion(string ll, string rr){
		string[] separador ={" "," "};
		string[] words = ll.Split(separador, StringSplitOptions.RemoveEmptyEntries);
		//Debug.Log (words [0] + "-" + words [1]);
		string[] words2 = rr.Split(separador, StringSplitOptions.RemoveEmptyEntries);
		if(words[1]!=null&&words2[1]!=null){
			calle.GetComponentInChildren<Text>().text="Calle "+words [1];
			carrera.GetComponentInChildren<Text>().text="Carrera " +words2 [1];
		}
	}

	public void cambiarRuta(string r){
		ruta.GetComponentInChildren<Text>().text=r;
	}

	public void cambiarCamino(string c){
		camino.GetComponentInChildren<Text>().text=c;
	}

	public void cambiarLugar(string l){
		lugar.GetComponentInChildren<Text>().text=l;
	}

	public void activarSenal(int s){

		walk.GetComponent<Image> ().enabled = false;
		bus.GetComponent<Image> ().enabled = false;
		alto.GetComponent<Image> ().enabled = false;

		switch(s){
			case 1: walk.GetComponent<Image> ().enabled = true; break;
			case 2: bus.GetComponent<Image> ().enabled = true; break;
			case 3: alto.GetComponent<Image> ().enabled = true; break;
		}
	}
}
