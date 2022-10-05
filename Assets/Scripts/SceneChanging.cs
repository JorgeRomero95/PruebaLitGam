using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChanging : MonoBehaviour
{

    public Button BotonCambioDeEscena;


    public void PressionoUnBoton()
    {
        if(BotonCambioDeEscena.interactable != true)
        {
            BotonCambioDeEscena.interactable = true;

        }
    }
    public void CambiarEscena()
    {
        ObjetosEstaticos.Escena++;
        SceneManager.LoadScene(1);
    }
}
