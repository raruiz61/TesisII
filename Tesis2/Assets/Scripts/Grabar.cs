using UnityEngine;
using System.Collections;

public class Grabar : MonoBehaviour {
	public string[] lines = { "First line", "Second line", "Third line" };

	// Use this for initialization
	void Start () {
		//grabar();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// Example #1: Write an array of strings to a file.
	// Create a string array that consists of three lines.


	public void grabar(){
		// WriteAllLines creates a file, writes a collection of strings to the file,
		// and then closes the file.  You do NOT need to call Flush() or Close().
		string[] texto = new string[3];

		texto[0] = "---------------------------------------------------------------------------------------------";

		texto[1] = GameObject.Find ("Player").GetComponent<Pruebas> ().recolectar ();

		texto[2]  = "---------------------------------------------------------------------------------------------";

			

		//System.IO.File.WriteAllLines(@"C:\Users\Imagine\Desktop\WriteLines.txt", texto);

		// Example #4: Append new text to an existing file.
		// The using statement automatically flushes AND CLOSES the stream and calls 
		// IDisposable.Dispose on the stream object.
		using (System.IO.StreamWriter file = 
		       new System.IO.StreamWriter(@"pruebas.txt", true))
		{
			for(int i=0;i<3;i++){
				file.WriteLine(texto[i]);
			}
		}
	}
}
