using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    /**
    * __particulasExplosion__ : _Particulas cuando pasa la explosion_
    */
    public GameObject particulasExplosion;

    /**
    * Funcion en donde se detecta cuando la Bala colisiona
    */
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Suelo")
        {
            Invoke("Explotar", 3);
        }
        if (collision.gameObject.tag == "Obstaculo" || collision.gameObject.tag == "Objetivo") Explotar();
    }

    /**
    * Funcion en donde la Bala explota
    */
    public void Explotar()
    {
        GameObject particulas = Instantiate(particulasExplosion, transform.position, Quaternion.identity) as GameObject;

        this.GetComponent<MeshRenderer>().enabled = false;
        this.GetComponent<Collider>().enabled = false;
        var particulaSystem = particulas.GetComponent<ParticleSystem>();
        SeguirCamara.objetivo = particulas;
        Invoke("_DespuesDeExplosion", (particulaSystem.main.startLifetime.constant + particulaSystem.main.duration - 0.02f));
    }

    /**
    * Funcion en donde se dan unos parametros una vez que pasa la explosion
    */
    void _DespuesDeExplosion()
    {

        Canon.Bloqueado = false;
        SeguirCamara.objetivo = null;
        Destroy(this.gameObject);
    }
}
