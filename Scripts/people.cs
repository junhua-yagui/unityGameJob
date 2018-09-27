using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class people : MonoBehaviour {

    Text text;

    //player's hp
    public int hp=20;

    //static people
    public static people instance; 

    //colect money
    public bool ifCollect = false;
    public static int charge = 0;
    public AudioClip collectSound;

    //game over
    public OverPad overpad;
    

    void Start()    
    {
        instance = this;
    }

    void Update()
    {
       
    }
    //收集金币
    void CellPickUp()
    {
        ifCollect=false;
        AudioSource.PlayClipAtPoint(collectSound,transform.position);
        charge++;
        if (charge > 0)
        {
            ifCollect = true;
        }
    }

    public void changeHp(int num)
    {
        hp+=num;
        if (hp <= 0)
        {
            Debug.Log("主角已经死亡。");
            if (overpad.gameObject.activeSelf == false)
            {
                overpad.gameObject.SetActive(true);
            }
            Time.timeScale = 0;
        }
    }

}
