using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomerangBullet : MonoBehaviour
{
    bool go;//Will Be Used To Change Direction Of Weapon

    [SerializeField]
    public GameObject player;//Reference To The Main Character
    [SerializeField]
    public GameObject BoomerangGameObject;
    public float velocidad;//Reference To The Main Character's Weapon

    Transform itemToRotate;//The Weapon That Is A Child Of The Empty Game Object

    Vector3 locationInFrontOfPlayer;//Location In Front Of Player To Travel To


    // Use this for initialization
    void Start()
    {
        go = false; //Set To Not Return Yet

        BoomerangGameObject.SetActive(false); //Turn Off The Mesh Render To Make The Weapon Invisible

        itemToRotate = this.gameObject.transform; //Find The Weapon That Is The Child Of The Empty Object       

        //Adjust The Location Of The Player Accordingly, Here I Add To The Y position So That The Object Doesn't Go Too Low ...Also Pick A Location In Front Of The Player
        locationInFrontOfPlayer = new Vector3(player.transform.position.x, player.transform.position.y + 1, player.transform.position.z) + player.transform.forward * 5f;

        StartCoroutine(Boom());//Now Start The Coroutine
    }

    IEnumerator Boom()
    {
        go = true;
        yield return new WaitForSeconds(1.5f);//Any Amount Of Time You Want
        go = false;
    }


    // Update is called once per frame
    void Update()
    {
        itemToRotate.transform.Rotate(0, 0, Time.deltaTime * 500); //Rotate The Object

        if (go)
        {
            transform.position = Vector3.MoveTowards(transform.position, locationInFrontOfPlayer, Time.deltaTime * velocidad); //Change The Position To The Location In Front Of The Player            
        }

        if (!go)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(player.transform.position.x, player.transform.position.y + 1, player.transform.position.z), Time.deltaTime * velocidad); //Return To Player
        }

        if (!go && Vector3.Distance(player.transform.position, transform.position) < 1.5)
        {
            //Once It Is Close To The Player, Make The Player's Normal Weapon Visible, and Destroy The Clone
            BoomerangGameObject.SetActive(true);
            Destroy(this.gameObject);
        }
    }
}
