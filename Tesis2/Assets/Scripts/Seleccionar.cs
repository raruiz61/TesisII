using UnityEngine;
using System.Collections;

public class Seleccionar : MonoBehaviour {
	public bool start;
	public bool end;

	// Use this for initialization
	void Start () {
		start = false;
		end = false;
	}
	
	// Update is called once per frame
	void Update () {
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if (Physics.Raycast(ray, out hit, 100)) {
			//Debug.DrawLine(ray.origin, hit.point);
			//Debug.Log(hit.collider.name);
			if(start==false){
				if(Input.GetMouseButtonDown (1)){
					GameObject.Find("Inicio").GetComponent<TextMesh>().text=GameObject.Find(hit.collider.name).GetComponentInChildren<TextMesh>().text;
					GameObject.Find("Ruta").GetComponent<Variables>().inicioRuta=GameObject.Find(hit.collider.name).GetComponentInChildren<TextMesh>().text;
					start=true;
				}
			}else{
				if(Input.GetMouseButtonDown (1)){
					GameObject.Find("Final").GetComponent<TextMesh>().text=GameObject.Find(hit.collider.name).GetComponentInChildren<TextMesh>().text;
					GameObject.Find("Ruta").GetComponent<Variables>().finalRuta=GameObject.Find(hit.collider.name).GetComponentInChildren<TextMesh>().text;
					if(GameObject.Find("Ruta").GetComponent<Variables>().inicioRuta!=GameObject.Find("Ruta").GetComponent<Variables>().finalRuta){
						end=true;
					}
				}
			}
			//Debug.Log(GameObject.Find(hit.collider.name).GetComponentInChildren<TextMesh>().text+" /**/");
			if(start==true&&end==true){
				iniciar();
			}

		}
	}

	public void iniciar(){
		Debug.Log (GameObject.Find("Ruta").GetComponent<Variables>().inicioRuta);
		Debug.Log (GameObject.Find("Ruta").GetComponent<Variables>().finalRuta);
		Application.LoadLevel("Terreno");
		Object.DontDestroyOnLoad(GameObject.Find("Ruta"));
	}
}
