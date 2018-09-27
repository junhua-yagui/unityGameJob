using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour {

    public Rigidbody bullet;
   public float power = 1600f;
    // private float time = 0.0f;
    public float throwSpeed = 30.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire2"))
        {
            Rigidbody instance = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody;
           //instance = GetComponent<Rigidbody>();
            // Vector3 fwd = new Vector3(Screen.width / 2, Screen.height / 2, 0);
            Vector3 fwd = transform.TransformDirection(Vector3.forward);
           // instance.velocity = throwSpeed * transform.forward;
            instance.AddForce(power * fwd);
            //Physics.IgnoreCollision(transform.root.collider,instance.collider,true);
        }
	}
}
