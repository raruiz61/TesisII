using UnityEngine;
using System.Collections;

public class Grabar : MonoBehaviour {
	public string[] lines = { "First line", "Second line", "Third line" };

	// Use this for initialization
	void Start () {
		grabar();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// Example #1: Write an array of strings to a file.
	// Create a string array that consists of three lines.


	public void grabar(){
		// WriteAllLines creates a file, writes a collection of strings to the file,
		// and then closes the file.  You do NOT need to call Flush() or Close().
		System.IO.File.WriteAllLines(@"C:\Users\LaptopRafael\Documents\TesisII\Tesis2\Assets\Pruebas\WriteLines.txt", lines);

		// Example #4: Append new text to an existing file.
		// The using statement automatically flushes AND CLOSES the stream and calls 
		// IDisposable.Dispose on the stream object.
		using (System.IO.StreamWriter file = 
		       new System.IO.StreamWriter(@"C:\Users\LaptopRafael\Documents\TesisII\Tesis2\Assets\Pruebas\WriteLines.txt", true))
		{
			file.WriteLine("Fourth line");
		}
	}
}
