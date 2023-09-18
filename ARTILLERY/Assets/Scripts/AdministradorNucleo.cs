using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AdministradorNucleo : MonoBehaviour
{
    /**
    * __GameWon__ : _Evento en donde se gana el juego_
    */
    public UnityEvent GameWon;

    /**
    * __enemiesDestroyed__ : _Cantidad de enemigos destruidos_
    */
    private int enemiesDestroyed = 0;

    /**
    * __requiredEnemiesToWin__ : _cantidad de enemigos que se tienen que matar para ganar_
    */
    private int requiredEnemiesToWin = 1;

    /**
    * Funcion en donde se desactiva el collider del nucleo
    */
    private void FixedUpdate()
    {
        if (AdministradorJuego.SingletonAdministradorJuego.juegoGanado)
        {
            this.GetComponent<Collider>().enabled = false;
        }
    }

    /**
    * Funcion en donde se destruye el nucleo para activar la victoria
    */
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Explosion" || other.tag == "Bala")
        {
            Destroy(this.gameObject);
            AdministradorJuego.SingletonAdministradorJuego.Nucleo_Destruido();
            enemiesDestroyed++;

            if (enemiesDestroyed >= requiredEnemiesToWin)
            {
                GameWon.Invoke();
            }
        }
    }
}



