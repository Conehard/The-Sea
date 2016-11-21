using UnityEngine;
using System.Collections;

public class playerControl : MonoBehaviour {
	public GameObject player;

	public float maxHeight;
	public float minHeight;

	public float speed;
	public float posicaox;

	public int score;

	public TextMesh total;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		float translation = Input.GetAxis("Fire1")*speed;
		player.transform.Translate (0,translation,0);
		if (player.transform.position.y > maxHeight) {
			player.transform.position = new Vector2 (posicaox,maxHeight);		
		}
		if (player.transform.position.y < minHeight) {
			player.transform.position = new Vector2 (posicaox,minHeight);		
		}

		total.text = score.ToString ();

	}

	void OnTriggerEnter2D (Collider2D col){
		Application.LoadLevel("gameover");
	}

	public void addscore(){
		score++;
	}
}
