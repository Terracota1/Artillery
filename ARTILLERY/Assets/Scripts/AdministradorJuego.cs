using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AdministradorJuego : MonoBehaviour
{
    public GameObject CanvasGanar;
    public GameObject CanvasPerder;
    public bool juegoGanado = false;
    private bool nucleoDestruido = false;

    public static AdministradorJuego SingletonAdministradorJuego;

    [SerializeField] float velocidadBala = 1f;
    public float _VelocidadBala_Get { get => velocidadBala; }

    [SerializeField] int DisparosPorJuego = 10;
    public int _DisparosRestantes_Get { get => DisparosPorJuego; }

    [SerializeField] float VelocidadRotacion = 1;
    public float _VelocidadRotacion_Get { get => VelocidadRotacion; }

    private int enemigosDestruidos = 0;

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
        if (DisparosPorJuego <= 0 && nucleoDestruido == false)
        {
            PerderJuego();
        }

        if (nucleoDestruido && enemigosDestruidos == 4)
        {
            GanarJuego();
        }
    }

    public void GanarJuego()
    {
        if (Canon.Bloqueado == false && CanvasPerder.activeSelf == false && nucleoDestruido == true)
        {
            juegoGanado = true;
            CanvasGanar.SetActive(true);
        }
    }

    public void PerderJuego()
    {
        if (Canon.Bloqueado == false && CanvasGanar.activeSelf == false && nucleoDestruido == false)
        {
            CanvasPerder.SetActive(true);
        }
    }

    public void Nucleo_Destruido()
    {
        nucleoDestruido = true;
    }

    public void EnemigoDestruido()
    {
        enemigosDestruidos++;
    }

    public int _EnemigosDestruidos_Get()
    {
        return enemigosDestruidos;
    }
}
