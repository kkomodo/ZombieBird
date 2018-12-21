using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bola : MonoBehaviour
{
    [SerializeField] private int velocidad =5;
    [SerializeField] private int limitesuperior = 2;
    [SerializeField] private int limiteinferior = -1;
    [SerializeField] private float posicion;




    

    // Use this for initialization
    void Start()
    {
        posicion = Random.Range(limitesuperior, limiteinferior);
        transform.position = new Vector3(transform.position.x,transform.position.y + posicion , transform.position.z);

    }

    // Update is called once per frame
    void Update()
    {
        if (GameConfig.IsPlaying()) {
           transform.Translate(Vector3.left * Time.deltaTime * velocidad);
            if (transform.position.x < -5)
            {
            Destroy(gameObject);
            }  
            
        }
       
    }
	    private void OnTriggerEnter(Collider pajaro){
			print ("Trigger");
		pajaro.GetComponent<pajaro>().AgrandarPajaro();
		}



}
