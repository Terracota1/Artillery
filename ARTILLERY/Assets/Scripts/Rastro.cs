using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rastro : MonoBehaviour
{
    [Header("Configurar en editor")]

    /**
    * __distanciaMinimaEntrePuntos__ : _Distancia minima que existira entre los puntos_
    */
    public float distanciaMinimaEntrePuntos = 0.1f;

    /**
    * __Linea__ : _Linea que seguira a la bala_
    */
    private LineRenderer linea;

    /**
    * ___objetivoLinea__ : _Objeto que tendra la linea dentro de la escena_
    */
    private GameObject _objetivoLinea;

    /**
    * __puntos__ : _Lista de los puntos_
    */
    private List<Vector3> puntos;

    /**
    * Funcion en donde se creara la linea que seguira a la Bala
    */
    public GameObject objetivoLinea
    {
        get
        {
            return (_objetivoLinea);
        }

        set
        {
            _objetivoLinea = value;
            if (_objetivoLinea != null)
            {
                linea.enabled = false;
                puntos = new List<Vector3>();
                AgregarPunto();
            }
        }
    }

    /**
    * Funcion en donde se dejara de crear lalinea que sigue a la Bala
    */
    public Vector3 UltimoPunto
    {
        get
        {
            if (puntos == null)
            {
                return (Vector3.zero);
            }
            return (puntos[puntos.Count - 1]);
        }
    }

    /**
    * Funcion en donde se iran colocando los puntos mientras la Bala avanza
    */
    public void AgregarPunto()
    {
        Vector3 punto = _objetivoLinea.transform.position;
        if (puntos.Count > 0 && (punto - UltimoPunto).magnitude < distanciaMinimaEntrePuntos)
        {
            return;
        }

        puntos.Add(punto);
        linea.positionCount = puntos.Count;
        linea.SetPosition(puntos.Count - 1, UltimoPunto);
        linea.enabled = true;
    }

    /**
    * Funcion en donde se consiguiran los componentes para que la Linea se pueda crear
    */
    private void Awake()
    {
        linea = GetComponent<LineRenderer>();
        linea.enabled = false;
        puntos = new List<Vector3>();
    }

    /**
    * Funcion en donde la camara seguira a Bala
    */
    private void FixedUpdate()
    {
        if (_objetivoLinea == null)
        {
            if (SeguirCamara.objetivo != null)
            {
                if (SeguirCamara.objetivo.tag == "Bala")
                {
                    objetivoLinea = SeguirCamara.objetivo;
                }
                else
                {
                    return;
                }
            }
            else
            {
                return;
            }
        }

        if (SeguirCamara.objetivo == null)
        {
            objetivoLinea = null;
        }
        else
        {
            if (SeguirCamara.objetivo.tag == "Bala")
            {
                AgregarPunto();
            }
        }
    }
}
