using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnSubmarino: MonoBehaviour {
	public float maxHeight;
	public float minHeight;
	public float rateSpawn;
	public GameObject prefab;
	public List<GameObject> submarino;
	public int maxSubmarino;
	private float currentRateSpawn;



	// Use this for initialization
	void Start () {
	
		for (int i=0; i < maxSubmarino; i++) {

			GameObject tempSubmarino = Instantiate(prefab)as GameObject;
			submarino.Add(tempSubmarino); 
			tempSubmarino.SetActive(false);
		}

	}
	
	// Update is called once per frame
	void Update () {
	
		
		
		currentRateSpawn += Time.deltaTime;
		
		if (currentRateSpawn > rateSpawn) {
			currentRateSpawn = 0;
			Spawn();
		}
		
		
	}
	
	private void Spawn(){
		
		float randPosition = Random.Range (minHeight, maxHeight);
		
		GameObject tempSubmarino = null;
		
		for (int i=0; i < maxSubmarino; i++) {
			if(submarino[i].activeSelf == false){
				tempSubmarino = submarino[i];
				break;
			}
		}
		
		if (tempSubmarino != null) {
			tempSubmarino.transform.position = new Vector3(transform.position.x,randPosition,transform.position.z);
			tempSubmarino.SetActive(true);
		}
		
		
		
		
	}

	}

