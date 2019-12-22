using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class pcScript : MonoBehaviour {

	private Rigidbody rbd;
	public float velocidade;
	public float velocidadeRot;
	private float rotY=0;
	private float rotX=0; 
	// Use this for initialization
	void Start () {
		rbd = GetComponent<Rigidbody> ();
		velocidade = 40;
		velocidadeRot = 100;
		Cursor.lockState = CursorLockMode.Locked;
	}
	
	// Update is called once per frame
	void Update () {

		float z = Input.GetAxis ("Vertical");
		float x = Input.GetAxis ("Horizontal");
		rotY += Input.GetAxis ("Mouse X") * velocidadeRot * Time.deltaTime;
		rbd.velocity = transform.TransformDirection(new Vector3 (x* velocidade,0,z* velocidade));
		transform.localEulerAngles = new Vector3(0,rotY,0);
		Camera.main.transform.localEulerAngles = new Vector3 (Mathf.Clamp(0,-20,20),0,0);

	}


}
