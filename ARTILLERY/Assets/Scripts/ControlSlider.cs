using UnityEngine;
using UnityEngine.UI;

public class ControlSlider : MonoBehaviour
{
    public Slider sliderFuerza;
    public AdministradorJuego administradorJuego;

    public void Start()
    {
        sliderFuerza = GetComponent<Slider>();
        sliderFuerza.onValueChanged.AddListener(delegate { ControlarCambios(); });
    }

    public void ControlarCambios()
    {
        AdministradorJuego.SingletonAdministradorJuego.CambiarVelocidad(sliderFuerza.value);
    }
}

