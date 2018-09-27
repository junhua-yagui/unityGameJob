using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSource : MonoBehaviour {

    //zombie's prefabs
    public NewZombieScipt[] prefabs;
    //store zombies
    public List<NewZombieScipt> zombies;
    //zombie's nums
    public int numCount = 3;

	// Use this for initialization
	void Start () {
		zombies = new List<NewZombieScipt>();
        StartCoroutine(CreateZombie());
	}

    NewZombieScipt nzs = new NewZombieScipt();
    IEnumerator CreateZombie()
    {
        while (true)
        {
            if (zombies.Count < numCount)
            {
                NewZombieScipt nzb = Instantiate(prefabs[Random.Range(0, prefabs.Length)], this.transform.position, Quaternion.identity) as NewZombieScipt;
                zombies.Add(nzb);
                yield return nzb;
            }
            yield return null;
        }
    }

	
	// Update is called once per frame
	void Update () {
        numCount = nzs.getCountNum(numCount);
	}

}
