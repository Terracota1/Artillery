using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdministradorJuego : MonoBehaviour
{
    public GameObject CanvasGanar;
    public GameObject CanvasPerder;
    public bool juegoGanado = false;

    public static AdministradorJuego SingletonAdministradorJuego;

    [SerializeField] float velocidadBala = 1f;
    public float _VelocidadBala_Get { get => velocidadBala; }

    [SerializeField] int DisparosPorJuego = 5;
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

    public void CambiarVelocidad(float nuevaVelocidad)
    {
        velocidadBala = nuevaVelocidad;

        Bala Bala = FindObjectOfType<Bala>();
        if (Bala != null)
        {
            AdministradorJuego.SingletonAdministradorJuego.velocidadBala = nuevaVelocidad;
        }
    }

    private void Update()
    {
        if (DisparosPorJuego <= 0)
        {
            PerderJuego();
        }

    }

    public void GanarJuego()
    {
        juegoGanado = true;
        CanvasGanar.SetActive(true);
    }

    public void PerderJuego()
    {
        CanvasPerder.SetActive(true);
    }
}

