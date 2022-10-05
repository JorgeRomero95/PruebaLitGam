using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHoleLaunch : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocidad = 5;
    public List <GameObject> Liberables;

      void Start()
    {
        Invoke("cronometro",10);
        Liberables = new List<GameObject>();
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Rigidbody>() != null)
        Liberables.Add(other.gameObject);
    }
    public void OnTriggerStay (Collider other)
    {
        if (other.gameObject.GetComponent<Rigidbody>()!=null  && other.gameObject.tag=="BlackHole")
        {
            Vector3 Dir = transform.position - other.gameObject.transform.position;
            Vector3 Dirscale = Vector3.Scale(Dir.normalized,gameObject.transform.localScale);
            other.gameObject.GetComponent<Rigidbody>().useGravity=false;
            other.gameObject.GetComponent<Rigidbody>().AddForce(Dirscale*20,ForceMode.Acceleration);
            other.transform.Translate(new Vector3 (0,0,velocidad*Time.deltaTime));
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<Rigidbody>() != null)
            other.gameObject.GetComponent<Rigidbody>().useGravity = true;
    }
    public void Update()
    {
       this.transform.Translate(new Vector3(0, 0, velocidad/2 * Time.deltaTime));

    }

    private void cronometro()
    {
        foreach (var item in Liberables)
        {
            item.gameObject.GetComponent<Rigidbody>().useGravity = true;
        }
        Liberables.Clear();

        Destroy(this.gameObject);
    }
 
}
