using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enums
{
    public enum TipoDeArma
    {
        Automatica,
        Rafaga,
        DisparoUnico
    }

    public enum TipoDeAnimacion
    {
        EsIdle,
        EsHouse,
        EsLaMacarena,
        EsWave
    }

}



public static class ObjetosEstaticos
{
    public static Enums.TipoDeAnimacion Animation { get; set; }
    public static int Escena { get; set; }

}
