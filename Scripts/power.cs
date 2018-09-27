using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class power : MonoBehaviour {

    public GameObject GO;
    public GUIText guit;

    public float speed = 30.0f;
    public bool ifCollects = false;
    Text text;
    public static int charge = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0,speed*Time.deltaTime,0);
	}

    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == "Player")
        {
            charge++;
            Destroy(this.gameObject);
            GameObject ifCollect = GameObject.Find("/Canvas/TextTwo");
            ifCollect.GetComponent<Text>().text = charge.ToString();
        }
    }
        //ifCollects= GetComponent<people>().ifCollect;
}
