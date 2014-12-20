using UnityEngine;
using System.Collections;

public class RestartGame : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		Debug.Log("start");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D col){
		Application.LoadLevel(Application.loadedLevel);
		Debug.Log("restart");
	}
}
