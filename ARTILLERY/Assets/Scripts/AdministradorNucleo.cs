using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AdministradorNucleo : MonoBehaviour
{
    public UnityEvent GameWon;

    private int Enemigos_Que_Se_Necesitan_Destruir = 4;

    private void FixedUpdate()
    {
        if (AdministradorJuego.SingletonAdministradorJuego.juegoGanado)
        {
            this.GetComponent<Collider>().enabled = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Explosion" || other.tag == "Bala")
        {
            Destroy(this.gameObject);
            AdministradorJuego.SingletonAdministradorJuego.Nucleo_Destruido();
            AdministradorJuego.SingletonAdministradorJuego.EnemigoDestruido(); 
            int enemigosDestruidos = AdministradorJuego.SingletonAdministradorJuego._EnemigosDestruidos_Get(); 

            if (enemigosDestruidos == Enemigos_Que_Se_Necesitan_Destruir)
            {
                GameWon.Invoke();
            }
        }
    }
}


