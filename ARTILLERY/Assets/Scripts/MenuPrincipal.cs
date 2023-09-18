using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    /**
    * __MenuOpciones__ : _Es el menu de Opciones_
    */
    public GameObject MenuOpciones;

    /**
    * __MenuInicial__ : _Es el menu inicial_
    */
    public GameObject MenuInicial;

    /**
    * Funcion para iniciar el juego
    */
    public void IniciarJuego()
    {
        SceneManager.LoadScene(1);
    }

    /**
    * Funcion para quitar el juego
    */
    public void finalizarJuego()
    {
        Application.Quit();
    }

    /**
    * Funcion para mostrar las opciones
    */
    public void MostrarOpciones()
    {
        MenuInicial.SetActive(false);
        MenuOpciones.SetActive(true);
    }

    /**
    * Funcion para mostrar el menu inicial
    */
    public void MostrarMenuIncial()
    {
        MenuOpciones.SetActive(false);
        MenuInicial.SetActive(true);
    }
}
