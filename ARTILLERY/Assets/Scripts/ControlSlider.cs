using UnityEngine;
using UnityEngine.UI;

public class ControlSlider : MonoBehaviour
{
    public Slider sliderFuerza;
    public AdministradorJuego administradorJuego;

    private void Start()
    {
        sliderFuerza.onValueChanged.AddListener(ActualizarFuerzaCanon);
    }

    private void ActualizarFuerzaCanon(float valor)
    {
        if (administradorJuego != null)
        {
            float velocidadMinima = 1f;
            float velocidadMaxima = 10f;

            float velocidadBala = Mathf.Lerp(velocidadMinima, velocidadMaxima, valor);

            administradorJuego.SetVelocidadBala(velocidadBala);
        }
    }
}

