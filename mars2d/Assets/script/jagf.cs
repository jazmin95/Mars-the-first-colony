using UnityEngine;
using System.Collections;

public class jagf : MonoBehaviour {

	float velocidad = 0.2f;
	Animator animacion;

	// Use this for initialization
	void Start () {
		animacion = GetComponentInChildren<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			transform.position = new Vector2 (transform.position.x, transform.position.y + velocidad);
			animacion.SetBool ("atras", true);
			animacion.SetBool ("delante", false);
			animacion.SetBool ("izquierda", false);
			animacion.SetBool ("derecha", false);
			animacion.SetBool("parado",false);
		} else
		if (Input.GetKey (KeyCode.S)) {
			transform.position = new Vector2 (transform.position.x, transform.position.y - velocidad);
			animacion.SetBool ("delante", true);
			animacion.SetBool ("atras", false);
			animacion.SetBool ("izquierda", false);
			animacion.SetBool ("derecha", false);
			animacion.SetBool("parado",false);
		} else
		if (Input.GetKey (KeyCode.A)) {
			transform.position = new Vector2 (transform.position.x - velocidad, transform.position.y);
			animacion.SetBool ("izquierda", true);
			animacion.SetBool ("atras", false);
			animacion.SetBool ("delante", false);
			animacion.SetBool ("derecha", false);
			animacion.SetBool("parado",false);
		} else
		if (Input.GetKey (KeyCode.D)) {
			transform.position = new Vector2 (transform.position.x + velocidad, transform.position.y);
			animacion.SetBool ("derecha", true);
			animacion.SetBool ("atras", false);
			animacion.SetBool ("izquierda", false);
			animacion.SetBool ("delante", false);
			animacion.SetBool("parado",false);
		} else {
			animacion.SetBool("parado",true);
			animacion.SetBool ("derecha", false);
			animacion.SetBool ("atras", false);
			animacion.SetBool ("izquierda", false);
			animacion.SetBool ("delante", false);
		}
	}
}