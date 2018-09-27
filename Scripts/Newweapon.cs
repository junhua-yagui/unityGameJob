using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Newweapon : MonoBehaviour {

    //枪声
    public AudioSource audio;
    public AudioClip shotSound;

    //光线
    public LineRenderer lineRenderer;
    public Vector3 position;  

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("Fire1"))
        {
            //手枪的声音
            audio.PlayOneShot(shotSound);
            //Vector3 origin = transform.position;
            //Vector3 direction = transform.forward;
            //Ray ray = new Ray(origin,direction);
        
            //Debug.Log(Physics.Raycast(origin,direction));
            //Debug.DrawLine(ray.origin,ray.direction*100);

           
        }
	}
}
