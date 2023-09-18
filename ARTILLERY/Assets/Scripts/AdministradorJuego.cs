using System.Collections.Generic;
using UnityEngine;

public class AdministradorJuego : MonoBehaviour
{
    /**
    * __CanvasGanar__ : _Es el menu cuando se gana la partida_
    */
    public GameObject CanvasGanar;

    /**
    * __CanvasPerder__ : _Es el menu cuando se pierde la partida_
    */
    public GameObject CanvasPerder;
    /**
    * __juegoGanado__ : _Variable Bool para saber si se gano el juego_
    */
    public bool juegoGanado = false; 

    /**
    * __nucleoDestruido__ : _Variable Bool para saber si se destruyo el nucleo_
    */
    private bool nucleoDestruido = false;

    /**
    * __SingletonAdministradorJuego__ : _Singleton principal del juego_
    */
    public static AdministradorJuego SingletonAdministradorJuego;

    /**
    * __velocidadBala__ : _La velocidad de la Bala_
    */
    [SerializeField] float velocidadBala = 1f;

    /**
    * __VelocidadBala_Get__ : _Funcion para obtener la velocidad de la Bala_
    */
    public float _VelocidadBala_Get { get => velocidadBala; }

    /**
    * __DisparosPorJuego__ : _Cantidad de disparos por juego_
    */
    [SerializeField] int DisparosPorJuego = 10;
    /**
    * __DisparosRestantes_Get__ : _Funcion para obtener los disparos restantes_
    */
    public int _DisparosRestantes_Get { get => DisparosPorJuego; }

    /**
    * __VelocidadRotacion__ : _Variable Bool para saber si se gano el juego_
    */
    [SerializeField] float VelocidadRotacion = 1;
    /**
    * __VelocidadRotacion_Get__ : _Funcion para obtener la rotacion del Canon_
    */
    public float _VelocidadRotacion_Get { get => VelocidadRotacion; }

    /**
     *  Funcion para saber si ya existe o no una instancia de la clase \n
     */
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

    /**
    *  Funcion para Reducir los Disparos Restantes\n
    */
    public void ReducirDisparosRestantes()
    {
        DisparosPorJuego--;
    }

    /**
    *  Funcion para cambiar la velocidad de la bala dependiendo de lo que se le asigne \n 
    */
    public void CambiarVelocidad(float nuevaVelocidad)
    {
        velocidadBala = nuevaVelocidad;

        Bala Bala = FindObjectOfType<Bala>();
        if (Bala != null)
        {
            AdministradorJuego.SingletonAdministradorJuego.velocidadBala = nuevaVelocidad;
        }
    }

    /**
    *  Funciones que se encargan de activar el menu de perder o ganar juego \n 
    */
    private void Update()
    {
        if (DisparosPorJuego <= 0 && nucleoDestruido == false)
        {
            PerderJuego();
        }

        if (nucleoDestruido)
        {
            GanarJuego();
        }

    }

    /**
    *  Funcion que activa el menu de Ganar Juego y no deja que otro menu se active \n 
    */
    public void GanarJuego()
    {
        if (Canon.Bloqueado == false && CanvasPerder.activeSelf == false && nucleoDestruido == true)
        {
            juegoGanado = true;
            CanvasGanar.SetActive(true);
        }
    }

    /**
    *  Funcion que activa el menu de Perder Juego y no deja que otro menu se active \n 
    */
    public void PerderJuego()
    {
        if (Canon.Bloqueado == false && CanvasGanar.activeSelf == false && nucleoDestruido == false)
        {
            CanvasPerder.SetActive(true);
        }
    }

    /**
    *  Funcion que activa el bool de que ya se destruyo el nucleo \n 
    */
    public void Nucleo_Destruido()
    {
        nucleoDestruido = true;
    }
}