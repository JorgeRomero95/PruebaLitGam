using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Enums;

[RequireComponent(typeof(Animator))]
public class AnimationChanging : MonoBehaviour
{
    [SerializeField]
    Animator animator;
    [SerializeField]
    AnimatorController animatorController;

    TipoDeAnimacion miAnimacionActual;
    private void Awake()
    {
        animator = GetComponent<Animator>();
        animator.runtimeAnimatorController = animatorController;
        ValidarEscena();
    }

    void ValidarEscena()
    {
        if(ObjetosEstaticos.Escena == 1)
        {
            miAnimacionActual = ObjetosEstaticos.Animation;
            ActualizarAnimacion(true);
        }
    }


    public void ChangeAnimation(int tipoDeAnimacion)
    {
        miAnimacionActual = (TipoDeAnimacion)tipoDeAnimacion;
        ActualizarAnimacion(false);
        ObjetosEstaticos.Animation = miAnimacionActual;

    }

    void ActualizarAnimacion(bool esLooping)
    {
        switch (miAnimacionActual)
        {
            case TipoDeAnimacion.EsIdle:
                animator.SetBool("EsHouse", false);
                animator.SetBool("EsLaMacarena", false);
                animator.SetBool("EsWave", false);
                animator.SetBool("EsLooping", esLooping);
                break;
            case TipoDeAnimacion.EsHouse:
                animator.SetBool("EsHouse", true);
                animator.SetBool("EsLaMacarena", false);
                animator.SetBool("EsWave", false);
                animator.SetBool("EsLooping", esLooping);
                break;
            case TipoDeAnimacion.EsLaMacarena:
                animator.SetBool("EsHouse", false);
                animator.SetBool("EsLaMacarena", true);
                animator.SetBool("EsWave", false);
                animator.SetBool("EsLooping", esLooping);
                break;
            case TipoDeAnimacion.EsWave:
                animator.SetBool("EsHouse", false);
                animator.SetBool("EsLaMacarena", false);
                animator.SetBool("EsWave", true);
                animator.SetBool("EsLooping", esLooping);
                break;

        }
    }

}
