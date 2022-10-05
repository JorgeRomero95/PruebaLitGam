using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponsUser : MonoBehaviour
{
    [SerializeField]
    List<GameObject> objetosPlayer;
    [SerializeField]
    Image imagenDeUbicacion;
    [SerializeField]
    List<Sprite> sprites;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            objetosPlayer[0].SetActive(true);
            objetosPlayer[1].SetActive(false);
            objetosPlayer[2].SetActive(false);
            imagenDeUbicacion.sprite = sprites[0];

        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            objetosPlayer[0].SetActive(false);
            objetosPlayer[1].SetActive(true);
            objetosPlayer[2].SetActive(false);
            imagenDeUbicacion.sprite = sprites[1];


        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            objetosPlayer[0].SetActive(false);
            objetosPlayer[1].SetActive(false);
            objetosPlayer[2].SetActive(true);
            imagenDeUbicacion.sprite = sprites[2];

        }
    }



}
