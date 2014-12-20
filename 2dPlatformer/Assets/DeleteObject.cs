using UnityEngine;
using System.Collections;

public class DeleteObject : MonoBehaviour {
	private float deleteTime = 8;
	private float currentTime = 0;
	// Use this for initialization
	void Start () {
		GetComponent<Animator>().enabled=true;

	}
	
	// Update is called once per frame
	void Update () {
		currentTime += Time.deltaTime;
		if (deleteTime <= currentTime)
		Destroy(this.gameObject);


	}



}
