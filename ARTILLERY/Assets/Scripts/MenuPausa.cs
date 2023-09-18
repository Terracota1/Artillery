using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    /**
    * __menuPausa__ : _Mostrar el menu de pausa_
    */
    public GameObject menuPausa;
    /**
    * __menuOpciones__ : _Mostrar el menu de opciones_
    */
    public GameObject menuOpciones;

    /**
    * Funcion para mostrar el menu pausa
    */
    public void MostrarMenuPausa()
    {
        menuPausa.SetActive(true);
        if (menuOpciones.activeInHierarchy) menuOpciones.SetActive(false);
    }

    /**
    * Funcion para ocultar el menu pausa
    */
    public void OcultarMenuPausa()
    {
        menuPausa.SetActive(false);
    }

    /**
    * Funcion para regresar a la pantalla principal
    */
    public void RegresarAPantallaPrincipal()
    {
        SceneManager.LoadScene(0);
    }

    /**
    * Funcion para mostrar el menu de opciones
    */
    public void MostrarMenuOpciones()
    {
        menuPausa.SetActive(false);
        menuOpciones.SetActive(true);
    }

}