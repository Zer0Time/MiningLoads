using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terrain_Gen : MonoBehaviour {
    public Transform Rock;
    public Transform Iron_Ore;
    public Transform Copper_Ore;
    public Transform Tin_Ore;

    // Use this for initialization
    void Start ()
    {
        Terrain_Spawn();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Terrain_Spawn()
    {
        
        int x = 100;
        int x2 = x / 2;
        int y = 100;
        for (int i = 0; i <x; i++)
        {
            Instantiate(Rock, new Vector3(x2-i, 0, 0), Quaternion.identity);
            for(int j = 0;j<y; j++)
            {
                int random = Random.Range(1, 10);
                switch (random)
                {
                    case 1: Instantiate(Iron_Ore, new Vector3(x2 - i, -1 + -j, 0), Quaternion.identity);
                        break;                   
                    case 2: Instantiate(Copper_Ore, new Vector3(x2 - i, -1 + -j, 0), Quaternion.identity);
                        break;
                    case 3: Instantiate(Tin_Ore, new Vector3(x2 - i, -1 + -j, 0), Quaternion.identity);
                        break;
                    default: Instantiate(Rock, new Vector3(x2 - i, -1 + -j, 0), Quaternion.identity);
                        break;
                }
                
            }
        }
    }
       
}
