using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Custom Weapon", order = 0)]
public class Weapon : ScriptableObject
{

    public string NombreDelArma;

    public Enums.TipoDeArma tipoDeArma;

    public GameObject Bala;

    public float VelocidadDeLaBala;

    public float DanoBala;

}
