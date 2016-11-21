using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnObject : MonoBehaviour {
	public float maxHeight;
	public float minHeight;
	public float rateSpawn;
	public GameObject prefab;
	public List<GameObject> tubarao;
	public int maxTubaroes;
	private float currentRateSpawn;



	// Use this for initialization
	void Start () {
	
		for (int i=0; i < maxTubaroes; i++) {

			GameObject tempTubarao = Instantiate(prefab)as GameObject;
			tubarao.Add(tempTubarao); 
			tempTubarao.SetActive(false);
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
		
		GameObject tempTubarao = null;
		
		for (int i=0; i < maxTubaroes; i++) {
			if(tubarao[i].activeSelf == false){
				tempTubarao = tubarao[i];
				break;
			}
		}
		
		if (tempTubarao != null) {
			tempTubarao.transform.position = new Vector3(transform.position.x,randPosition,transform.position.z);
			tempTubarao.SetActive(true);
		}
		
		
		
		
	}

	}

