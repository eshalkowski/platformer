using UnityEngine;
using System.Collections;

public class DisplayTime : MonoBehaviour {
	private KeepTime timer;
	private GUIStyle styleTime;
	private GUIStyle styleLabel;
	// Use this for initialization
	void Start () {
		GameObject go = GameObject.Find ("Game");
		timer = go.GetComponent <KeepTime> ();
		styleLabel = new GUIStyle();
		styleTime = new GUIStyle();
		styleTime.fontSize= 33;
		styleLabel.fontSize = 55;

	}
	
	// Update is called once per frame
	void Update () {
		timer.getTime();
	}
	void OnGUI() {
		string time = "" + (int)(timer.getTime());
		GUI.Label(new Rect(10, 10, 100, 20),"Time" , styleLabel);
		GUI.Label(new Rect(75, 75, 100, 20),time , styleTime);
	}
}
