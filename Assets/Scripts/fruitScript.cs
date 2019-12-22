using UnityEngine;
using System.Collections;

public class fruitScript : MonoBehaviour {

	private static gameScript script;

	// Use this for initialization
	void Start () {
 

		if(script == null)
			script = GameObject.Find ("controladorJogo").GetComponent<gameScript>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnCollisionEnter(Collision collision){

		if (collision.gameObject.tag == "Player") {

			Destroy (this.gameObject);
			script.incrementaScore ();

		}
	}
}
