using UnityEngine;
using System.Collections;

public class KeepTime : MonoBehaviour {
	private double gameTime;
	// Use this for initialization
	void Start () {
		gameTime = 0.0;
	}
	
	// Update is called once per frame
	void Update () {
		gameTime += Time.deltaTime;
		Debug.Log (gameTime);
	}
	public double getTime(){
		return gameTime;
	}
}
