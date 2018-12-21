using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipegenerator : MonoBehaviour {
    [Header("PREFAB")]
    [SerializeField] Transform prefabtuberia;

	// Use this for initialization
	void Start () {     
        InvokeRepeating("GenerarPipe", 1.0f, 2.5f);
	}

    private void GenerarPipe()
    {
        Instantiate(prefabtuberia,transform.position,Quaternion.identity);

    }
	
}
