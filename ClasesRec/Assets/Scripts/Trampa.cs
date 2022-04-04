using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampa : MonoBehaviour
{

    InstanciadorRocas instanciadorRocas;

    // Start is called before the first frame update
    void Start()
    {
        instanciadorRocas = GameObject.Find("Instanciador").GetComponent<InstanciadorRocas>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Nave")
        {
            instanciadorRocas.IniciarLanzamiento();

            Animator animator = GameObject.Find("obst").GetComponent<Animator>();
            animator.SetTrigger("Cambio");
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Nave")
        {
           // instanciadorRocas.PararLanzamiento();
        }
    }


}
