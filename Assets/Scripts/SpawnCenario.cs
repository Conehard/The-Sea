using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnCenario : MonoBehaviour {
	public float maxHeight;
	public float minHeight;
	public float rateSpawn;
	public GameObject prefab;
	public List<GameObject> cenario;
	public int maxCenario;
	private float currentRateSpawn;
	
	
	
	// Use this for initialization
	void Start () {
		
		for (int i=0; i < maxCenario; i++) {
			
			GameObject tempCenario = Instantiate(prefab)as GameObject;
			cenario.Add(tempCenario); 
			tempCenario.SetActive(false);
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
		
		GameObject tempCenario = null;
		
		for (int i=0; i < maxCenario; i++) {
			if(cenario[i].activeSelf == false){
				tempCenario = cenario[i];
				break;
			}
		}
		
		if (tempCenario != null) {
			tempCenario.transform.position = new Vector3(transform.position.x,randPosition,transform.position.z);
			tempCenario.SetActive(true);
		}
		
		
		
		
	}
	
}

