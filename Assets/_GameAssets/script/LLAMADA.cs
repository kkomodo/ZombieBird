using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LLAMADA : MonoBehaviour {

	public void Empezar(){
    	SceneManager.LoadScene(1);
		//SceneManager.LoadScene(0);
	}
	
	public void Terminar(){
		Application.Quit();
	}
}