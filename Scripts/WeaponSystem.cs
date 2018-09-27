using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]//序列化
public class WeaponData
{
    public int id;
    public Transform prefob;//武器预置体
}

public class WeaponSystem : MonoBehaviour {

    public static WeaponSystem instance;
    public Transform weaponContainer;
    public WeaponData[] list;
    public int num;
    private int _curWeaponId = 0;

    public int CurWeaponId
    {
        get { return _curWeaponId; }
        set { _curWeaponId = value; }
    }
    public WeaponData curWeaponData;
    
	// Use this for initialization
	void Start () {
        instance = this;
        _curWeaponId = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public WeaponData GetWeaponData(int weaponId)
    {
        foreach (WeaponData wd in list)
        {
            if (wd.id == weaponId)
            {
                return wd;
            }
        }
        return null;
    }

}
