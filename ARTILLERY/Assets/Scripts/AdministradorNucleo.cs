using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AdministradorNucleo : MonoBehaviour
{
    public UnityEvent GameWon;

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
            GameWon.Invoke();
        }
    }
}
