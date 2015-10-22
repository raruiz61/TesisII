using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Senales : MonoBehaviour {

	public GameObject calle;
	public GameObject carrera;
	public GameObject walk;
	public GameObject alto;
	public GameObject bus;
	// Use this for initialization
	void Start () {
		walk.GetComponent<Image> ().enabled = false;
		bus.GetComponent<Image> ().enabled = false;
		alto.GetComponent<Image> ().enabled = true;
		//cambiarUbicacion ();

	}
	
	// Update is called once per frame
	void Update () {


	}

	public void cambiarUbicacion(string ll, string rr){
		calle.GetComponentInChildren<Text>().text=ll;
		carrera.GetComponentInChildren<Text>().text=rr;
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
