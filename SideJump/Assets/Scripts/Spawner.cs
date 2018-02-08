using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public Transform[] spawnPoints;
	public GameObject[] prefab;

	public float timetospawn=2f;
	public float t=2f;
	public int[,] pos = new int[,] { 
		{5,4,3,0,1,2},
		{5,0,0,3,0,0},
		{5,3,0,4,5,0},
		{5,4,0,4,1,0},
		{5,3,1,6,7,8},
		{5,3,1,9,10,2},
		{5,1,0,9,2,0},
		{5,2,3,11,3,12},
		{5,4,0,4,13,0},
		{5,0,0,4,0,0},
		{6,0,0,3,0,0},
		{6,0,0,4,0,0},
		{6,3,0,11,12,0},
		{6,2,0,14,3,0},
		{6,1,0,14,15,0},
		{2,0,0,16,0,0},
		{4,0,0,17,0,0},
		{1,4,0,18,19,0},
		{1,2,0,2,20,0},
		{2,0,0,20,0,0}
	                                    };

	void Update()
	{
		if(Time.time>=timetospawn)
		{
			SpawnBlocks ();
			timetospawn =Time.time + t;
		}
	}
	void SpawnBlocks()
	{
		int random1 = Random.Range (0,3);
		int random2 = Random.Range (0,20);
		if(random1==0)
		{
			for (int i = 0; i < 3; i++) {
				if(pos[random2,i]!=0)
				{
					Instantiate (prefab[pos[random2,i]-1],spawnPoints[pos[random2,i+3]+21].position,Quaternion.identity);
				}	
			}

		}
		if(random1==1)
		{
			for (int i = 0; i < 3; i++) {
				if(pos[random2,i]!=0)
				{
					Instantiate (prefab[pos[random2,i]-1],spawnPoints[pos[random2,i+3]].position,Quaternion.identity);
				}	
			}
		
		}
		if(random1==2)
		{
			int random3 = Random.Range (0,20);
			for (int i = 0; i < 3; i++) {
				if(pos[random3,i]!=0)
				{
					Instantiate (prefab[pos[random3,i]-1],spawnPoints[pos[random3,i+3]+21].position,Quaternion.identity);
				}	
			}
			for (int i = 0; i < 3; i++) {
				if(pos[random2,i]!=0)
				{
					Instantiate (prefab[pos[random2,i]-1],spawnPoints[pos[random2,i+3]].position,Quaternion.identity);
				}	
			}
		}

	}
}
