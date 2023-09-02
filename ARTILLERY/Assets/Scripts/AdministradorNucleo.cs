using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AdministradorNucleo : MonoBehaviour
{
    public UnityEvent GameWon;
    public GameObject Menu_Fin_Nivel;

    private void OnTriggereEnter(Collider other)
    {
        if (other.tag == "Explosion")
        {
            GameWon.Invoke();
            Destroy(this.gameObject);
            //Menu_Fin_Nivel.SetActive(true);
        }
    }
}
