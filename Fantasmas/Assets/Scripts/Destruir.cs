using UnityEngine;
using System.Collections;

public class Destruir : MonoBehaviour {
	
	public float tiempoDeVida = 2f;

	// Use this for initialization
	void Start () {
		Destroy(gameObject, tiempoDeVida);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
