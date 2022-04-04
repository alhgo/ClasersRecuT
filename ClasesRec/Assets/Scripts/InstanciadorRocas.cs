using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciadorRocas : MonoBehaviour
{

    [SerializeField] GameObject roca;

    bool estoyLanzando = false;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void IniciarLanzamiento()
    {
        if(!estoyLanzando)
        {
            StartCoroutine("Lanzamiento");
            estoyLanzando = true;
        }
            

    }

    public void PararLanzamiento()
    {
        StopCoroutine("Lanzamiento");
    }

    IEnumerator Lanzamiento()
    {
        while(true)
        {
            LanzarRoca();
            yield return new WaitForSeconds(1f);

        }
    }

    void LanzarRoca()
    {
        float randomValue = Random.Range(-5f, 5f);
        Vector3 despl = new Vector3(randomValue, 0f, 0f);
        Instantiate(roca, gameObject.transform.position + despl, Quaternion.identity);
        
    }


}
