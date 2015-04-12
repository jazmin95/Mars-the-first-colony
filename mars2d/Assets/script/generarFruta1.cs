using UnityEngine;
using System.Collections;

public class generarFruta1 : MonoBehaviour {

	public GameObject fruta1;
	public float time = 10f;

	// Use this for initialization
	void Start () {
		generar ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void generar(){
		Instantiate (fruta1,this.transform.position,Quaternion.identity);
		Invoke ("generar", time);
	}
}
