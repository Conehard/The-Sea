using UnityEngine;
using System.Collections;

public class TubaraoBehaviour : MonoBehaviour {
	public float speed;
	public GameObject tubarao;
	private playerControl player;
	private bool sobreviveu;


	// Use this for initialization
	void Start () {
		player = FindObjectOfType (typeof(playerControl)) as playerControl;
	}

	void OnEnable(){
		sobreviveu = false;
	}

	// Update is called once per frame
	void Update () {

		transform.position += new Vector3 (speed, 0, 0) * Time.deltaTime;

		if (transform.position.x < player.transform.position.x && !sobreviveu) {
			player.addscore();
			sobreviveu = true;
			
			Debug.Log(player.score);
		}
		
		if (transform.position.x < -9.2f) {
			
			tubarao.SetActive(false);
		}


	}
}
