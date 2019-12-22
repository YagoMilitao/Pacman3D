﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ghostScript : MonoBehaviour {

	public GameObject target;
	UnityEngine.AI.NavMeshAgent agent;

	// Use this for initialization
	void Start () {
		agent = GetComponent<UnityEngine.AI.NavMeshAgent> ();
		if (target == null) {

			target = GameObject.FindGameObjectWithTag ("Player");

		}
	}
 
	// Update is called once per frame
	void Update () {
		agent.destination = target.transform.position;
	}


	public void OnCollisionEnter(Collision collision){

		if (collision.gameObject.tag == "Player") {

			SceneManager.LoadScene (0);

		}
	}
}
