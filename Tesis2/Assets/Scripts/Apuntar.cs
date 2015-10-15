using UnityEngine;
using System.Collections;

public class Apuntar : MonoBehaviour {

	public GameObject objetivo;
	public Vector3 direccion;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		this.transform.LookAt(objetivo.transform.position);
		this.transform.Rotate (Vector3.right, 90);

	}
}
