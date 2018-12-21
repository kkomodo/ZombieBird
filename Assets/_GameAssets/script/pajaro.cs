using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pajaro : MonoBehaviour {
    [SerializeField] Rigidbody rb;
    [SerializeField] int fuerza = 200;
    [SerializeField] int puntos = 0;
    [SerializeField] Text marcadorPuntos;
    [SerializeField] ParticleSystem prefabExplosion;
    [SerializeField] AudioSource sonidoExplosion;
    [SerializeField] float x = 0.4f;
    [SerializeField] float y = 0.1f;
    [SerializeField] float z = 0.8f;
    [SerializeField] float tamanox   
    [SerializeField]  tamanoy; 
    [SerializeField]  tamanoz;
    [SerializeField] float agranda = 1;   


    AudioSource sonidoPuntuacion;
     


    // Use this for initialization
    void Start () {

        GameConfig.ArrancaJuego();

        rb = gameObject.GetComponent<Rigidbody>();
        marcadorPuntos.text = "Puntos";
        sonidoPuntuacion = GetComponent<AudioSource>();
        
        tamanox = transform.position.x;
        tamanoy = transform.position.y;
        tamanoz = transform.position.z

    }              

    void Update () {
        
        if (Input.GetKeyDown("space"))
        {
            //Debug.Log("PULSADO ESPACIO");
           rb.AddForce(transform.up * fuerza);
        }
        //print(transform.position.y );
         if (transform.position.y < -4)
        {
               //print("ha entrado");
           
            Invoke("Finalizarpartida", 0.5f );

        Destroy(gameObject,1);
        }  
        
        
	}

    private void OnTriggerEnter(Collider other)
    {
        puntos += 1;
        // MOSTRAR PUNTOS
        MarcadorPuntos(); 
       // print ("colisiona" + puntos );
       sonidoPuntuacion.Play();
       
    }

    private void OnCollisionEnter(Collision colisionador) {

        //print("Nombre colision "+colisionador.gameObject.name);
        if (colisionador.gameObject.name == "árbolinferior" || 
        colisionador.gameObject.name == "árbolinferior") {
            GameConfig.PararJuego();
            //print("choco");
            Instantiate(prefabExplosion,transform.position,Quaternion.identity);
            sonidoExplosion.Play();
            gameObject.SetActive(false);
            Invoke("Finalizarpartida", 0.5f );
        }  
        else if (colisionador.gameObject.name == "Grande")  {

        }
       
    }
    
    void MarcadorPuntos(){
       marcadorPuntos.text = "Puntos:" + puntos;
    }

    private void Finalizarpartida()
    {
        SceneManager.LoadScene(0);
    }

public void AgrandarPajaro(){
  		transform.localScale = new Vector3(tamanox, tamanoy,tamanoz);

}
   // private void OnTriggerEnter(Collider grande)

    
}