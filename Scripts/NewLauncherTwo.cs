using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewLauncherTwo : MonoBehaviour {

    //generate money after kill zombies
    public Rigidbody money;

    //image after kill zombies
    public Image Bg;
    public static int ImageI=3;

    //kill zombie count
    public int killCount = 0;
    public Text killText;

    //shooting aim's game obkect
    public GameObject shootingaim;
    //shooting aim's image
    public Image shootingImage;
    //zombie's hp
    public static int hp=3;

    public bool die = false;

    public GameObject zombie;

    Rigidbody moneys;
    //stop the moneys up
    int moneysHeightCount = 0;

	// Use this for initialization
	void Start () {
        shootingImage = shootingaim.GetComponent<Image>();
    }

    killCounter kc = new killCounter();

	
	// Update is called once per frame
	void Update () {
        if (moneys != null && moneysHeightCount<20)
        {
            moneys.transform.Translate(Vector3.up * Time.deltaTime, Space.World);
            moneysHeightCount++;
        }
        if (Input.GetButtonDown("Fire1"))
        {
            Fire();
            killText.text = killCount.ToString();//count zombie kill
        }
        if (Input.GetButtonUp("Fire1"))
        {
            shootingImage.color = Color.green;
            if (hp == 3)
            {
                ReleaseImage();
            }
        }
	}


    void Fire()
    {
        Vector3 origin = Camera.main.transform.position;
        Vector3 direction = Camera.main.transform.forward;
        Ray ray = new Ray(origin, direction);
        RaycastHit hitInfo;
        //if (Physics.Raycast(ray, out hitInfo))
        //{
        //    Debug.Log(hitInfo.transform.tag);
        //}
        Debug.Log(Physics.Raycast(ray));
        Debug.DrawRay(ray.origin, ray.direction * 100);

        //firehit test
        if (Physics.Raycast(ray,out hitInfo))
        {
            switch (hitInfo.transform.tag)
            {
                case"Zombie":
                    shootingImage.color = Color.red;
                    hp--;
                    if (hp <= 0)
                    {
                        zombie = GameObject.FindWithTag("Zombie");
                        die = true;
                        Destroy(zombie);
                        CodeAfterZombiesDie();
                    }
                    break;
                case "ZombieTwo":
                    shootingImage.color = Color.red;
                    hp--;
                    if (hp <= 0)
                    {
                        zombie = GameObject.FindWithTag("ZombieTwo");
                        die = true;
                        Destroy(zombie);
                        CodeAfterZombiesDie(); ;
                    }
                    break;
                case "ZombieThree":
                    shootingImage.color = Color.red;
                    hp--;
                    if (hp <= 0)
                    {
                        zombie = GameObject.FindWithTag("ZombieThree");
                        die = true;
                        Destroy(zombie);
                        CodeAfterZombiesDie();
                    }
                    break;
                case "ZombieFour":
                    shootingImage.color = Color.red;
                    hp--;
                    if (hp <= 0)
                    {
                        zombie = GameObject.FindWithTag("ZombieFour");
                        die = true;
                        Destroy(zombie);
                        CodeAfterZombiesDie();
                    }
                    break;
                case "ZombieFive":
                    shootingImage.color = Color.red;
                    hp--;
                    if (hp <= 0)
                    {
                        zombie = GameObject.FindWithTag("ZombieFive");
                        die = true;
                        Destroy(zombie);
                        CodeAfterZombiesDie();
                    }
                    break;
                case "ZombieSix":
                    shootingImage.color = Color.red;
                    hp--;
                    if (hp <= 0)
                    {
                        zombie = GameObject.FindWithTag("ZombieSix");
                        die = true;
                        Destroy(zombie);
                        CodeAfterZombiesDie();
                    }
                    break;
                case "ZombieSeven":
                    shootingImage.color = Color.red;
                    hp--;
                    if (hp <= 0)
                    {
                        zombie = GameObject.FindWithTag("ZombieSeven");
                        die = true;
                        Destroy(zombie);
                        CodeAfterZombiesDie();
                    }
                    break;
                case "ZombieEight":
                    shootingImage.color = Color.red;
                    hp--;
                    if (hp <= 0)
                    {
                        zombie = GameObject.FindWithTag("ZombieEight");
                        die = true;
                        Destroy(zombie);
                        CodeAfterZombiesDie();
                    }
                    break;
                case "ZombieNine":
                    shootingImage.color = Color.red;
                    hp--;
                    if (hp <= 0)
                    {
                        zombie = GameObject.FindWithTag("ZombieNine");
                        die = true;
                        Destroy(zombie);
                        CodeAfterZombiesDie();
                    }
                    break;
                case "ZombieTen":
                    shootingImage.color = Color.red;
                    hp--;
                    if (hp <= 0)
                    {
                        zombie = GameObject.FindWithTag("ZombieTen");
                        die = true;
                        Destroy(zombie);
                        CodeAfterZombiesDie();
                    }
                    break;

            }
        }
        NewZombieScipt nzs = new NewZombieScipt();
        nzs.isDie(die);
        die = false;
    }

    //update maskImage after kill zombies
    public void UpadateImage()
    {
        //Image icon = transform.Find("/Canvas/MaskImage").GetComponent<Image>();
        // Sprite sp = Resources.Load("RPGicons/512/Ax_1", typeof(Sprite)) as Sprite;
        //icon.sprite = sp;
        if (killCount == 1|| ImageI%3==0)
        {
            Bg.GetComponent<Image>().sprite = Resources.Load("killOne", typeof(Sprite)) as Sprite;
        }
        else if (killCount == 2 || ImageI%2==0)
        {
            Bg.GetComponent<Image>().sprite = Resources.Load("killTwo", typeof(Sprite)) as Sprite;
        }else
        {
            Bg.GetComponent<Image>().sprite = Resources.Load("killThree", typeof(Sprite)) as Sprite;
        }
        ImageI++;
    }

    //release maskImage
    public void ReleaseImage()
    {
        Bg.GetComponent<Image>().sprite = Resources.Load("games", typeof(Sprite)) as Sprite;
    }
    
    //generate money after kill zombies
    public void GenerateMoney(GameObject zombie)
    {
        moneys = Instantiate(money,zombie.transform.position,zombie.transform.rotation) as Rigidbody;
    }

    //all the code after zombies die
    public void CodeAfterZombiesDie()
    {
        hp = 3;//reset zombie's hp
        killCount++;//count the num of kill
        UpadateImage();//update picture after kill zombies
        GenerateMoney(zombie);//generate money
        moneysHeightCount = 0;//reset the money's heightCount
    }
}
