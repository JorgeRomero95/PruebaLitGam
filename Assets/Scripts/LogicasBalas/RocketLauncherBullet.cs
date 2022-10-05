using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Scripts.LogicasBalas
{
    [RequireComponent(typeof(Rigidbody))]
    public class RocketLauncherBullet : MonoBehaviour
    {

        public float speed;

        void Update()
        {
            transform.position = new Vector3 (transform.position.x , transform.position.y, transform.position.z)+ transform.right*(speed *Time.deltaTime);
        }
        public void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag=="plano")
            {
                Destroy(this.gameObject);
            }
        }


    }
}
