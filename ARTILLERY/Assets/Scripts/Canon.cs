using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{
    public static bool Bloqueado;

    public AudioClip clipDisparo;
    private GameObject SonidoDisparo;
    private AudioSource SourceDisparo;

    [SerializeField] private GameObject BalaPrefab;
    public GameObject ParticulasDisparo;
    private GameObject puntaCanon;
    private float rotacion;

    void Start()
    {
        puntaCanon = transform.Find("PuntaCanon").gameObject;
        SonidoDisparo = GameObject.Find("SonidoDisparo");
        SourceDisparo = SonidoDisparo.GetComponent<AudioSource>();
    }

    void Update()
    {
        rotacion += Input.GetAxis("Horizontal") * AdministradorJuego.SingletonAdministradorJuego._VelocidadRotacion_Get;
        if (rotacion <= 90 && rotacion >= 0)
        {
            transform.eulerAngles = new Vector3(rotacion, 90, 0.0f);
        }

        if (rotacion > 90) rotacion = 90;
        if (rotacion < 0) rotacion = 0;

        if (Input.GetKeyDown(KeyCode.Space) && AdministradorJuego.SingletonAdministradorJuego._DisparosRestantes_Get > 0)
        {
            if (Input.GetKeyDown(KeyCode.Space) && !Bloqueado)
            {
                GameObject temp = Instantiate(BalaPrefab, puntaCanon.transform.position, transform.rotation);
                Rigidbody tempRB = temp.GetComponent<Rigidbody>();
                SeguirCamara.objetivo = temp;
                Vector3 direccionDisparo = transform.rotation.eulerAngles;
                direccionDisparo.y = 90 - direccionDisparo.x;
                Vector3 direccionParticulas = new Vector3(-90 + direccionDisparo.x, 90, 0);
                GameObject Particulas = Instantiate(ParticulasDisparo, puntaCanon.transform.position, transform.rotation);
                tempRB.velocity = direccionDisparo.normalized * AdministradorJuego.SingletonAdministradorJuego._VelocidadBala_Get;
                AdministradorJuego.SingletonAdministradorJuego.ReducirDisparosRestantes();
                SourceDisparo.PlayOneShot(clipDisparo);
                Bloqueado = true;
            }
        }
    }
}
