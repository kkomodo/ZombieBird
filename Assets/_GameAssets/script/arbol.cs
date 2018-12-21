using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arbol : MonoBehaviour
{
    [SerializeField] private int velocidad =5;
    [SerializeField] private int limitesuperior = 1;
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
//print(GameConfig.jugando);
           transform.Translate(Vector3.left * Time.deltaTime * velocidad);
            if (transform.position.x < -5)
            {
            Destroy(gameObject);
            }  
            
        }
       
    }


}
