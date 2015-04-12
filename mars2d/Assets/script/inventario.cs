using UnityEngine;
using System.Collections;

public class inventario : MonoBehaviour {

	private int puntosFruta1=0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D fruta){
		if(fruta.CompareTag("fruta1")){
			puntosFruta1 +=10;
			print (puntosFruta1);
			Destroy(fruta.gameObject);
		}
	}
}
