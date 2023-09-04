using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AdministradorNucleo : MonoBehaviour
{
    public UnityEvent GameWon;
    public GameObject Menu_Fin_Nivel;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Explosion")
        {
            Destroy(this.gameObject);
            GameWon.Invoke();
            //Menu_Fin_Nivel.SetActive(true);
        }
    }
}
