﻿using UnityEngine;
using System.Collections;

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
	public float velocidad;
	private float posicionNueva;

	// Use this for initialization
	void Start () {
		direccion = true;
		moverX = false;
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
		}
		posicionInicialx = this.transform.position.x;
		posicionInicialy = this.transform.position.y;
		posicionInicialz = this.transform.position.z;

		var step = velocidad * Time.deltaTime;

		if (siguiente != null) {
			// Move our position a step closer to the target.
			transform.position = Vector3.MoveTowards (transform.position, siguiente.transform.position, step);
		}

		//moverEnX ();
		//moverEnZ ();
		//transform.position = siguiente.transform.position;
		//GameObject.Find ("Protagonista").GetComponent<Retorno>().irBase();


		/*if (direccion) {
			if (moverX) {
				posicionNueva = this.transform.position.x + velocidad * Time.deltaTime;
				this.transform.position = new Vector3(posicionNueva, this.transform.position.y, this.transform.position.z);
				
			} else {
				posicionNueva = this.transform.position.z + velocidad * Time.deltaTime;
				this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, posicionNueva);
			}
			
			if(posicionNueva > posicionFinal) {
				direccion = false;
			}
		} else {
			if (moverX) {
				posicionNueva = this.transform.position.x - velocidad * Time.deltaTime;
				this.transform.position = new Vector3(posicionNueva, this.transform.position.y, this.transform.position.z);
				
			} else {
				posicionNueva = this.transform.position.z + velocidad * Time.deltaTime;
				this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, posicionNueva);
			}	

		}*/
	}

	void OnTriggerEnter(Collider coll) {
		Debug.Log (siguiente.name);
		siguiente = coll.gameObject.GetComponent<Paradas> ().siguiente;
		GameObject.Find ("Flecha").GetComponent<Apuntar> ().objetivo=siguiente;
		Debug.Log (siguiente.name);
	}
	
	public void moverEnX(){
		float dis = posicionFinalx - posicionInicialx;
		int dir = -1;
		if(dis>0){
			dir=1;
		}

		dis = Mathf.Abs (dis);
		Debug.Log (dis+" ** "+posicionInicialx);
		
		if(dis>0.01){
			posicionNueva = this.transform.position.x +dir* velocidad * Time.deltaTime;
			this.transform.position = new Vector3 (posicionNueva, this.transform.position.y, this.transform.position.z);
			posicionInicialx=posicionNueva;
		}
		
	}

	public void moverEnY(){
		float dis = posicionFinaly - posicionInicialy;
		int dir = -1;
		if(dis>0){
			dir=1;
		}
		dis = Mathf.Abs (dis);
		
		if(dis>0.01){
			posicionNueva = this.transform.position.y +dir* velocidad * Time.deltaTime;
			this.transform.position = new Vector3 (this.transform.position.x, posicionNueva, this.transform.position.z);
			posicionInicialy=posicionNueva;
		}
		
	}

	public void moverEnZ(){
		float dis = posicionFinalz - posicionInicialz;
		int dir = -1;
		if(dis>0){
			dir=1;
		}

		dis = Mathf.Abs (dis);
		
		if(dis>0.01){
			posicionNueva = this.transform.position.z +dir* velocidad * Time.deltaTime;
			this.transform.position = new Vector3 (this.transform.position.x,this.transform.position.y, posicionNueva);
			posicionInicialz=posicionNueva;
		}
		
	}
}
