using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class ControlSlider : MonoBehaviour
{
    /**
    * __sliderFuerza__ : _Slider para definir la fuerza de la Bala_
    */
    public Slider sliderFuerza;

    /**
    * __administradorJuego__ : _Variable de la logica principal del juego_
    */
    public AdministradorJuego administradorJuego;

    /**
    * __canonControls__ : _Controles del canon_
    */
    private CanonControls canonControls;

    /**
    * Funciones en donde basicamente se controla el slider y la se llama a la funcion que modifica la velocidad de la Bala
    */
    private void Start()
    {
        sliderFuerza = GetComponent<Slider>();
        sliderFuerza.onValueChanged.AddListener(delegate { ControlarCambios(); });
        canonControls = new CanonControls();
        canonControls.Enable();
        canonControls.Canon.ModificarFuerza.performed += context => ModificarVelocidad(context.ReadValue<float>());
    }

    /**
    * Funcion para desactivar los controles del Canon
    */
    private void OnDisable()
    {
        canonControls.Disable();
    }

    /**
    * Funcion donde se modifica la velocidad de la Bala
    */
    public void ModificarVelocidad(float value)
    {
        sliderFuerza.value += value * 1f;
        ControlarCambios();
    }

    /**
    * Funcion donde se controlan los cambios realizados a la velocidad de la Bala
    */
    public void ControlarCambios()
    {
        AdministradorJuego.SingletonAdministradorJuego.CambiarVelocidad(sliderFuerza.value);
    }
}

