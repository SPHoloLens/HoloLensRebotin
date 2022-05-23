using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncing : MonoBehaviour
{
    bool pega = false;
    public Vector3 Velocidad;
    // Use this for initialization
    void Start() {
    
    }

    void FixedUpdate()
    {
        //Almacenamos la velocidad que lleva antes de la colision
        void OnCollisionEnter(Collision coll)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(gameObject.GetComponent<Rigidbody>().velocity * -1);
        }
    }
}
