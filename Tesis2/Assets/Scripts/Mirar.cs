using UnityEngine;
using System.Collections;
using System;

public class Mirar : MonoBehaviour {
	public DateTime inicio; 	
	public DateTime final;
	public int vio;
	public string objeto="";
	public bool iniciar=true;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		Transform cam = Camera.main.transform;
		Ray ray = new Ray(cam.position, cam.forward);
		//Ray ray = Camera.main.ScreenPointToRay(mira.transform.position);
		RaycastHit hit;

		if (Physics.Raycast(ray, out hit, 100)) {
			//Debug.Log(hit.collider.name);
			//Debug.Log(hit.collider.name+" --");
			if(hit.collider.GetComponent<Street>()!=null){
				Debug.Log(hit.collider.name+" ++");
				if(hit.collider.name.Equals(objeto)&&hit.collider.GetComponent<Street>().lugar==true&&hit.collider.GetComponent<Street>().visto==false){
					//Debug.Log(hit.collider.name+" ==");
					if(iniciar==true){
						inicio = DateTime.Now;
						objeto=hit.collider.name;
						//Debug.Log(objeto+" ==");
						iniciar=false;
						//Debug.Log(DateTime.Now.ToString()+" ##");
					}
					final = DateTime.Now;
					TimeSpan transcurrido = final.Subtract(inicio);
					//Debug.Log(transcurrido.Seconds);
					Debug.Log(transcurrido.Seconds);
					//Debug.Log(final.ToString());
					if(transcurrido.Seconds>3){
						vio++;
						//Debug.Log(hit.collider.name);
						iniciar =true;
						transcurrido = inicio.Subtract(inicio);
						hit.collider.GetComponent<Street>().visto=true;
						Debug.Log(transcurrido.ToString());
					}
				}else{
					objeto=hit.collider.name;

				}

				if(hit.collider.GetComponent<Street>().lugar==true){
					GameObject.Find ("Player").GetComponent<Senales> ().cambiarLugar (hit.collider.GetComponent<Street>().nodo.GetComponent<Paradas>().lugar);
				}else{
					GameObject.Find ("Player").GetComponent<Senales> ().cambiarLugar ("");
				}
				//Debug.DrawLine(ray.origin, hit.point);	
			}
		}
	}
}
