using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AdministradorNucleo : MonoBehaviour
{
    public UnityEvent GameWon;

    private int enemiesDestroyed = 0;
    private int requiredEnemiesToWin = 4;

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
            enemiesDestroyed++;

            if (enemiesDestroyed >= requiredEnemiesToWin)
            {
                GameWon.Invoke();
            }
        }
    }
}



