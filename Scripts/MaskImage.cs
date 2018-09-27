using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaskImage : MonoBehaviour {

    public Image Bg;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

    //update maskImage after kill zombies
    public void UpadateImage()
    {
        //Image icon = transform.Find("/Canvas/MaskImage").GetComponent<Image>();
       // Sprite sp = Resources.Load("RPGicons/512/Ax_1", typeof(Sprite)) as Sprite;
        //icon.sprite = sp;

        Bg.GetComponent<Image>().sprite = Resources.Load("RPGicons/512/Ax_1", typeof(Sprite)) as Sprite;
    }

    //release maskImage
    public void ReleaseImage()
    {
        Image icon = transform.Find("/Canvas/MaskImage").GetComponent<Image>();
    }
}
