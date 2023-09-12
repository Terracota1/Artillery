using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class ControlSlider : MonoBehaviour
{
    public Slider sliderFuerza;
    public AdministradorJuego administradorJuego;

    private CanonControls canonControls;

    private void Start()
    {
        sliderFuerza = GetComponent<Slider>();
        sliderFuerza.onValueChanged.AddListener(delegate { ControlarCambios(); });
        canonControls = new CanonControls();
        canonControls.Enable();
        canonControls.Canon.ModificarFuerza.performed += context => ModificarVelocidad(context.ReadValue<float>());
    }
    private void OnDisable()
    {
        canonControls.Disable();
    }

    public void ModificarVelocidad(float value)
    {
        sliderFuerza.value += value * 1f;
        ControlarCambios();
    }

    public void ControlarCambios()
    {
        AdministradorJuego.SingletonAdministradorJuego.CambiarVelocidad(sliderFuerza.value);
    }
}

