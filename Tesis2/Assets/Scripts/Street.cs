using UnityEngine;
using System.Collections;

public class Street : MonoBehaviour {
	public double latitude=4.649388599999999;
	public double longitude=-74.062358;
	public double width=2048;
	public double height=2048;
	public double sideHeading;
	public double sidePitch;
	public string key;
	public double keyL=100.0;
	public double turn=0.0;
	public GameObject nodo;
	// Use this for initialization
	void Start () {

		//GetStreetviewTexture (0.0, 0.0, 0.0, 0.0);
		//Latitud 90
		//Longitud 180

		latitude=nodo.GetComponent<Paradas>().latitud;
		longitude=nodo.GetComponent<Paradas>().logitud;

		StartCoroutine(GetStreetviewTexture (latitude, longitude, turn, 0.0));

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private IEnumerator GetStreetviewTexture(double latitude, double longitude, double heading, double pitch = 0.0)
	{  
		//for (int i=0; i<10; i++) {
			//latitude=latitude+0.00011;
			//longitude=longitude-0.0001;
			//heading=heading+1; //Movimiento hotizontal
			//pitch=pitch+1;//Movimiento vertical

			string url = "http://maps.googleapis.com/maps/api/streetview?"
				+ "size=" + width + "x" + height
				+ "&location=" + latitude + "," + longitude
				+ "&heading=" + (heading + sideHeading) % 360.0 + "&pitch=" + (pitch + sidePitch) % 360.0  
				+ "&fov=90.0&sensor=false";
			//Debug.Log ("HOla");
			//string url= "http://maps.googleapis.com/maps/api/streetview?size=400x400&amp;location=40.720032,%20-73.988354&amp;fov=90&amp;heading=235&amp;pitch=10&amp;sensor=false&amp;key=AIzaSyADwO-XeEZOofljavyudvovGXGvpGS6KYU";
		

			//url= "http://127.0.0.1:1981/index.html?lat=4.649215&lng=-74.06236200000001&sock=127.0.0.1%3A1981&q=4&s=false&heading=0";

			if (key != "")
				url += "&key=" + key;
		
			WWW www = new WWW (url);
			//Debug.Log (url);
			yield return www;
			if (!string.IsNullOrEmpty (www.error))
				Debug.Log ("Panorama " + name + ": " + www.error);
			else
				print ("Panorama " + name + " loaded url " + url);
		
			//renderer.material.mainTexture = www.texture;
			GetComponent<Renderer> ().material.mainTexture = www.texture;
		//}
	}

}
