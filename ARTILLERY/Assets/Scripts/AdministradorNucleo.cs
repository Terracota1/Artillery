using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdministradorNucleo : MonoBehaviour
{
    public GameObject Menu_Fin_Nivel;

    public int resistencia = 1;

    void Update()
    {
        if (resistencia <= 0)
        {
            Destroy(this.gameObject);
            Menu_Fin_Nivel.SetActive(true);
        }
    }
}
