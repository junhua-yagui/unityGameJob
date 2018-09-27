using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewLauncher : MonoBehaviour {

    //光
    public GameObject lightobj;
    public Light light;
    public Texture texture;

	// Use this for initialization
	void Start () {
        lightobj = GameObject.Find("MyLight");
        light=lightobj.GetComponent<Light>();
        light.color = new Color(1f, 1f, 1f);
        light.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            //Vector3 origin = transform.position;
            //Vector3 direction = transform.TransformDirection(Vector3.forward);
            //Ray ray = new Ray(origin, direction);
            //Debug.Log(Physics.Raycast(origin, direction));
            //Debug.DrawLine(ray.origin, ray.direction * 100);

            light.enabled = true;
            
            //光的烘培
            light.lightmapBakeType = LightmapBakeType.Mixed;
            //光的强度
            light.intensity = 1;
            //光的阴影
            light.shadows = LightShadows.None;
            //Cookie
            light.cookie = texture;
        }
        if (Input.GetButtonUp("Fire1"))
        {
            light.enabled = false;
        }
	}
}
