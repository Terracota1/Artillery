using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class Canon : MonoBehaviour
{
    /**
    * __Bloqueado__ : _Variable bool para saber si el Canon esta o no bloqueado_
    */
    public static bool Bloqueado;

    /**
    * __velocidadBalaActual__ : _Variable para saber que velocidad tiene la Bala_
    */
    private float velocidadBalaActual;

    /**
    * __clipDisparo__ : _Variable que tiene el sonio del disparo_
    */
    public AudioClip clipDisparo; 

    /**
    * __clipDisparo__ : _Objeto que tiene el sonido del disparo_
    */
    private GameObject SonidoDisparo;

    /**
    * __SourceDisparo__ : _Fuente de donde viene el sonido_
    */
    private AudioSource SourceDisparo;

    /**
    * __BalaPrefab__ : _Prefab de la Bala_
    */
    [SerializeField] private GameObject BalaPrefab;

   /**
    * __ParticulasDisparo__ : _Particulas del disparo del Canon_
    */
    public GameObject ParticulasDisparo;

    /**
    * __puntaCanon__ : _La punta del Canon de donde salen las Bala_
    */
    private GameObject puntaCanon;

    /**
    * __rotacion__ : _Rotacion del canon_
    */
    private float rotacion;

    /**
    * __canonControls__ : _Controles del Canon_
    */
    public CanonControls canonControls;

    /**
    * __apuntar__ : _Apuntar el Canon_
    */
    private InputAction apuntar;

    /**
    * __modificarFuerza__ : _Fuerza del disparo del Canon_
    */
    private InputAction modificarFuerza;

    /**
    * __disparar__ : _Lanzar la bala_
    */
    private InputAction disparar;

    /**
    * __controlSlier__ : _Slider de la fuerza de la Bala_
    */
    [SerializeField] private ControlSlider controlSlider;

    /**
    * Funcion para activar los controles de Canon
    */
    private void Awake()
    {
        canonControls = new CanonControls();
    }

    /**
    * Funcion para activar las funciones del control del Canon
    */
    private void OnEnable()
    {
        apuntar = canonControls.Canon.Apuntar;
        modificarFuerza = canonControls.Canon.ModificarFuerza;
        disparar = canonControls.Canon.Disparar;
        apuntar.Enable();
        modificarFuerza.Enable();
        disparar.Enable();
        disparar.performed += Disparar;
    }

    /**
    * Funcion que desactiva la opcion de disparar
    */
    private void OnDisable()
    {
        disparar.performed -= Disparar;
    }

    /**
    * Funciones en donde se buscan los objetos para darle su respectiva funcion
    */
    void Start()
    {
        puntaCanon = transform.Find("PuntaCanon").gameObject;
        SonidoDisparo = GameObject.Find("SonidoDisparo");
        SourceDisparo = SonidoDisparo.GetComponent<AudioSource>();

        controlSlider = FindObjectOfType<ControlSlider>();
    }

    /**
    * Funciones en donde se asigna cuanto puede rotar el Canon, al igual que se le asigna la velocidad de la Bala
    */
    void Update()
    {
        rotacion += apuntar.ReadValue<float>() * AdministradorJuego.SingletonAdministradorJuego._VelocidadRotacion_Get;
        if (rotacion <= 90 && rotacion >= 0)
        {
            transform.eulerAngles = new Vector3(rotacion, 90, 0.0f);
        }

        if (rotacion > 90) rotacion = 90;
        if (rotacion < 0) rotacion = 0;

        velocidadBalaActual = controlSlider.sliderFuerza.value * AdministradorJuego.SingletonAdministradorJuego._VelocidadBala_Get;
    }

    /**
    * Funciones en donde practicamente se asigna a Bala como va a salir del Canon
    */
    private void Disparar(InputAction.CallbackContext context)
    {
        if (!Bloqueado && AdministradorJuego.SingletonAdministradorJuego._DisparosRestantes_Get > 0 && !AdministradorJuego.SingletonAdministradorJuego.juegoGanado)
        {
            GameObject temp = Instantiate(BalaPrefab, puntaCanon.transform.position, transform.rotation);
            Rigidbody tempRB = temp.GetComponent<Rigidbody>();
            SeguirCamara.objetivo = temp;
            Vector3 direccionDisparo = transform.rotation.eulerAngles;
            direccionDisparo.y = 90 - direccionDisparo.x;
            Vector3 direccionParticulas = new Vector3(-90 + direccionDisparo.x, 90, 0);
            GameObject Particulas = Instantiate(ParticulasDisparo, puntaCanon.transform.position, transform.rotation);
            AdministradorJuego.SingletonAdministradorJuego.ReducirDisparosRestantes();
            SourceDisparo.PlayOneShot(clipDisparo);
            Bloqueado = true;
            tempRB.velocity = direccionDisparo.normalized * velocidadBalaActual;
        }
    }
}
