using UnityEngine;
using System.Collections;

public class CenarioBehaviour : MonoBehaviour {
	public float speed;
	public GameObject cenario;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.position += new Vector3 (speed, 0, 0) * Time.deltaTime;
		
		if (transform.position.x < -9.2f) {
			
			cenario.SetActive(false);
	}
}
}