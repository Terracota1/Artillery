using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuFinDeNivel : MonoBehaviour
{
    /**
    * Funcion para pasar al siguiente nivel o poner el menu principal
    */
    public void SiguienteNivel()
    {
        var siguienteNivel = SceneManager.GetActiveScene().buildIndex + 1;
        if (SceneManager.sceneCountInBuildSettings > siguienteNivel)
        {
            SceneManager.LoadScene(siguienteNivel);
        }
        else
        {
            CargarMenuPrincipal();
        }
    }

    /**
    * Funcion para cargar el menu principal
    */
    public void CargarMenuPrincipal()
    {
        SceneManager.LoadScene(0);
    }

    /**
    * Funcion para reintentar el nivel
    */
    public void ReintentarNivel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
