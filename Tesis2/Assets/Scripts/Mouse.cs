using UnityEngine;
using System.Collections;

public class Mouse : MonoBehaviour {

	public int zoom=13;
	public GameObject ruta;

	// Use this for initialization
	void Start () {
	
	}
	
	void Update () {

		//Debug.Log (Input.GetAxis ("Mouse ScrollWheel"));
		/*
		if (Input.GetAxis ("Mouse ScrollWheel") < 0) { // back
			//Camera.main.orthographicSize = Mathf.Max(Camera.main.orthographicSize-1, 1);
			zoom--;
			GameObject.Find ("Plane").GetComponent<GoogleMap> ().Refresh ();
			
			
		}
		if (Input.GetAxis ("Mouse ScrollWheel") > 0) { // forward
			//Camera.main.orthographicSize = Mathf.Min(Camera.main.orthographicSize-1, 6);
			zoom++;

			GameObject.Find ("Plane").GetComponent<GoogleMap> ().Refresh ();
			//Debug.Log (Input.GetAxis("Mouse ScrollWheel"));
		}

		if (Input.GetMouseButtonDown (0)){
			//Debug.Log("Pressed left click.");
			GameObject.Find ("Plane").GetComponent<GoogleMap> ().centerLocation.latitude += 0.001;
			GameObject.Find ("Plane").GetComponent<GoogleMap> ().Refresh ();
		}
		
		if (Input.GetMouseButtonDown (1)) {
			GameObject.Find ("Plane").GetComponent<GoogleMap> ().centerLocation.latitude -= 0.001;
			GameObject.Find ("Plane").GetComponent<GoogleMap> ().Refresh ();
		}
		
		if (Input.GetMouseButtonDown(2))
			Debug.Log("Pressed middle click.");
		*/
		/*if (Input.GetAxis ("Mouse ScrollWheel") < 0) { // back
			//Camera.main.orthographicSize = Mathf.Max(Camera.main.orthographicSize-1, 1);
			zoom--;
			GameObject.Find ("Plane").GetComponent<GoogleMap> ().Refresh ();
			
			
		}
		if (Input.GetAxis ("Mouse ScrollWheel") > 0) { // forward
			//Camera.main.orthographicSize = Mathf.Min(Camera.main.orthographicSize-1, 6);
						
			GameObject.Find ("Plane").GetComponent<Street> ();
			//Debug.Log (Input.GetAxis("Mouse ScrollWheel"));
		}*/

		if (Input.GetButtonUp ("Fire1") == true) {
			GameObject.Find("RutaO").GetComponent<Variables>().inicioRuta=1;
			Application.LoadLevel("Terreno");
			Object.DontDestroyOnLoad(GameObject.Find("RutaO"));

		}

		if (Input.GetButtonUp ("Fire2") == true) {
			GameObject.Find("RutaO").GetComponent<Variables>().inicioRuta=4;
			Application.LoadLevel("Terreno");
			Object.DontDestroyOnLoad(GameObject.Find("RutaO"));
		}


	}
}
