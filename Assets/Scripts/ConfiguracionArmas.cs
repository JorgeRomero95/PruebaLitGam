using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfiguracionArmas : MonoBehaviour
{
    public Weapon miArma;

    public GameObject modelo;

    public Transform PosicionDeLaBala;

    public int MiArma;

    private void Update()
    {
        if (Input.GetMouseButtonDown(1) && modelo.activeInHierarchy)
        {
            GameObject Bullet = Instantiate(miArma.Bala, PosicionDeLaBala);
            switch (MiArma) { 
                case 2:
                    BoomerangBullet boomerang = Bullet.GetComponent<BoomerangBullet>();
            boomerang.BoomerangGameObject = this.gameObject;
            boomerang.velocidad = miArma.VelocidadDeLaBala;
            boomerang.player = player;
                    break; }
            
        }   
    }

    public GameObject player;
}
