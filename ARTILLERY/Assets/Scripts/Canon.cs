using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class Canon : MonoBehaviour
{
    public static bool Bloqueado;
    private float velocidadBalaActual;
    public Slider sliderFuerza;

    public AudioClip clipDisparo;
    private GameObject SonidoDisparo;
    private AudioSource SourceDisparo;

    [SerializeField] private GameObject BalaPrefab;
    public GameObject ParticulasDisparo;
    private GameObject puntaCanon;
    private float rotacion;
    public float velocidad;

    public CanonControls canonControls;
    private InputAction apuntar;
    private InputAction modificarFuerza;
    private InputAction disparar;

    private void Awake()
    {
        canonControls = new CanonControls();
    }

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

    private void OnDisable()
    {
        disparar.performed -= Disparar;
    }

    void Start()
    {
        puntaCanon = transform.Find("PuntaCanon").gameObject;
        SonidoDisparo = GameObject.Find("SonidoDisparo");
        SourceDisparo = SonidoDisparo.GetComponent<AudioSource>();

        ControlSlider controlSlider = FindObjectOfType<ControlSlider>();
        if (controlSlider != null)
        {
            sliderFuerza = controlSlider.sliderFuerza;
        }
    }

    void Update()
    {
        rotacion += apuntar.ReadValue<float>() * AdministradorJuego.SingletonAdministradorJuego._VelocidadRotacion_Get;
        if (rotacion <= 90 && rotacion >= 0)
        {
            transform.eulerAngles = new Vector3(rotacion, 90, 0.0f);
        }

        if (rotacion > 90) rotacion = 90;
        if (rotacion < 0) rotacion = 0;

        velocidadBalaActual = sliderFuerza.value * AdministradorJuego.SingletonAdministradorJuego._VelocidadBala_Get;
    }

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
