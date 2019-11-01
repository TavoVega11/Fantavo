using UnityEngine;
using System.Collections;

public class Disparo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		rigidbody.AddForce(transform.forward * 1000);
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.name == "Suelo") {
			EliminarDisparo ();
		} else if (other.tag == "Enemigo") {
			EliminarDisparo ();
			other.SendMessage("Muere", SendMessageOptions.DontRequireReceiver);
		}
		
	}
	
	void EliminarDisparo()
	{
		Destroy (gameObject, 1);
		GetComponentInChildren<ParticleSystem> ().enableEmission = false;
	}
}
