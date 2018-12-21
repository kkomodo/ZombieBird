using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorBolas : MonoBehaviour {
[Header("PREFAB")]
[SerializeField] Transform grande;

	// Use this for initialization
	void Start () {
	InvokeRepeating("GenerarBola", 2.0f, 6f);
	}
	
	// Update is called once per frame
	private void GenerarBola(){
		Instantiate(grande,transform.position,Quaternion.identity);

	}
}
