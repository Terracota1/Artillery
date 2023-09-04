using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AdministradorNucleo : MonoBehaviour
{
    public UnityEvent GameWon;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Explosion")
        {
            Destroy(this.gameObject);
            GameWon.Invoke();
        }
    }
}
