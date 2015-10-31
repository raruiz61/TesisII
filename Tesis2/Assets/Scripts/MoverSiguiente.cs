using UnityEngine;
using System.Collections;
using System;

public class MoverSiguiente : MonoBehaviour {

	public GameObject siguiente;
	public bool moverX;
	public float posicionInicial;

	public float posicionInicialx;
	public float posicionInicialy;
	public float posicionInicialz;

	public float posicionFinalx;
	public float posicionFinaly;
	public float posicionFinalz;

	public float posicionFinal;
	private bool direccion;
	public bool parar;
	public float velocidad;
	private float posicionNueva;
	public bool bus;

	// Use this for initialization
	void Start () {
		bus = false;
		direccion = true;
		moverX = false;
		parar=false;
	}
	
	// Update is called once per frame
	void Update () {

		//Debug.Log (siguiente);
		if (siguiente != null) {
			posicionFinalx = siguiente.transform.position.x;
			posicionFinaly = siguiente.transform.position.y;
			posicionFinalz = siguiente.transform.position.z;
		} else {
			posicionFinalx = this.transform.position.x;
			posicionFinaly = this.transform.position.y;
			posicionFinalz = this.transform.position.z;
			GameObject.Find ("Player").GetComponent<Pruebas>().final = DateTime.Now;
			GameObject.Find ("Player").GetComponent<Pruebas>().medirTiempo();
		}
		posicionInicialx = this.transform.position.x;
		posicionInicialy = this.transform.position.y;
		posicionInicialz = this.transform.position.z;

		var step = velocidad * Time.deltaTime;

		if (siguiente != null&&parar==false) {
			// Move our position a step closer to the target.
			transform.position = Vector3.MoveTowards (transform.position, siguiente.transform.position, step);
		}

		if(siguiente==null){
			GameObject.Find ("Player").GetComponent<Grabar> ().grabar();
		}
	}

	void OnTriggerEnter(Collider coll) {
		//Debug.Log (coll.name);
		if (coll.name.StartsWith ("Nodo") == true) {
			siguiente = coll.gameObject.GetComponent<Paradas> ().siguiente;
			GameObject.Find ("Flecha").GetComponent<Apuntar> ().objetivo = siguiente;
			if (coll.gameObject.GetComponent<Paradas>().cubo!= null) {
				parar = true;
				GameObject.Find ("Player").GetComponent<Senales> ().activarSenal (3);
				GameObject.Find ("Player").GetComponent<Senales> ().cambiarLugar (coll.gameObject.GetComponent<Paradas>().lugar);
				GameObject.Find ("Player").GetComponent<Senales>().cambiarUbicacion(coll.gameObject.GetComponent<Paradas>().calle,
				                                                                    coll.gameObject.GetComponent<Paradas>().carrera);
				if(coll.gameObject.GetComponent<Paradas>().paradero==true){
					bus=!bus;
				}
			}
		} 
	}
}
