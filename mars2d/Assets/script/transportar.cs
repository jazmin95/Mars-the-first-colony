using UnityEngine;
using System.Collections;

public class transportar : MonoBehaviour {

	public GameObject cris;
	public GameObject destino;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D objeto){
		if(objeto.CompareTag("chris")){
			cris.transform.position = destino.transform.position;
		}
	}
}
