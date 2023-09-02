using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdministradorJuego : MonoBehaviour
{
    public GameObject CanvasGanar;
    public GameObject CanvasPerder;

    public static AdministradorJuego SingletonAdministradorJuego;
    [SerializeField] int VelocidadBala = 30;
    public int _VelocidadBala_Get { get => VelocidadBala; }

    [SerializeField] int DisparosPorJuego = 10;
    public int _DisparosRestantes_Get { get => DisparosPorJuego; }

    [SerializeField] float VelocidadRotacion = 1;
    public float _VelocidadRotacion_Get { get => VelocidadRotacion; }

    private void Awake()
    {
        if (SingletonAdministradorJuego == null)
        {
            SingletonAdministradorJuego = this;
        }
        else
        {
            Debug.LogError("Ya existe una instancia de esta clase");
        }

    }

    public void ReducirDisparosRestantes()
    {
        DisparosPorJuego--;
    }

    private void Update()
    {
        if (DisparosPorJuego < 0)
        {
            PerderJuego();
        }
    }

    public void GanarJuego()
    {
        CanvasGanar.SetActive(true);
    }

    public void PerderJuego()
    {
        CanvasPerder.SetActive(true);
    }
}

