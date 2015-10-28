using UnityEngine;
using System.Collections;

public class Ruta : MonoBehaviour {
	public int inicio;
	public int final;
	public GameObject player;
	public GameObject lugar1;
	public GameObject lugar2;
	public GameObject lugar3;
	public GameObject lugar4;
	public GameObject ruta;
	public GameObject ruta1;
	public GameObject ruta2;
	public GameObject ruta3;
	public GameObject ruta4;
	public GameObject ruta5;
	public GameObject ruta6;
	public GameObject ruta7;
	public GameObject ruta8;
	public GameObject ruta9;
	public GameObject ruta10;
	public GameObject ruta11;
	public GameObject ruta12;
	public string rutaName;
	// Use this for initialization
	void Start () {
		//rutas=new GameObject[4][4];
		inicio=0;
		final=1;

		posicionar();
		rutaName=determinarRuta();
	}
	
	// Update is called once per frame
	void Update () {
		posicionar();
		rutaName=determinarRuta();
	}

	public void posicionar(){

		switch(inicio){
			case 1: player.transform.position=lugar1.transform.position;					
				break;
			case 2: player.transform.position=lugar2.transform.position;
				break;
			case 3: player.transform.position=lugar3.transform.position;
				break;
			case 4: player.transform.position=lugar4.transform.position;
				break;
		}
	}

	public string determinarRuta(){
		switch(inicio){
			case 1: return ruta1.name; break;
			case 2: return ruta5.name; break;
			case 3: return ruta6.name; break;
			case 4: return ruta10.name; break;
		}
		return "";
	}
}
