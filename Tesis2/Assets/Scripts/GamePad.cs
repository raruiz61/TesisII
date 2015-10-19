using UnityEngine;
using System.Collections;

public class GamePad : MonoBehaviour {

	private Vector3 movementVector;
	public GameObject player;
	private float movementSpeed = 1;
	private float jumpPower = 15;
	private float gravity = 40;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetAxis("Horizontal")!=0){
			movementVector.x = Input.GetAxis("Horizontal") * movementSpeed;
			movementVector.y = 0;
			movementVector.z = 0;
			player.transform.position+=movementVector;
			//Debug.Log(movementVector.x);
		}

		if(Input.GetAxis("Vertical")!=0){
			movementVector.z = Input.GetAxis("Vertical") * movementSpeed;
			movementVector.x = 0;
			movementVector.y = 0;
			player.transform.position+=movementVector;
			//Debug.Log(movementVector.x);
		}

		//if(Input.GetAxis("Fire1")!=0){
		if(Input.GetButtonUp("Fire1")==true){
			Debug.Log("Fuego "+Input.GetButtonUp("Fire1"));
			if(GameObject.Find("Player").GetComponent<MoverSiguiente>().parar==true){
				GameObject.Find("Player").GetComponent<MoverSiguiente>().parar=false;
			}else{
				GameObject.Find("Player").GetComponent<MoverSiguiente>().parar=true;
			}
		}

		//movementVector.z = Input.GetAxis("LeftJoystickY") * movementSpeed;




		/*if(characterController.isGrounded)
		{
			movementVector.y = 0;
			
			if(Input.GetButtonDown("A"))
			{
				movementVector.y = jumpPower;
			}
		}*/
	}
}
