using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
	public float spawnTime = 5f;		// The amount of time between each spawn.
	public float spawnDelay = 3f;		// The amount of time before spawning starts.
	public GameObject[] platforms;		// Array of enemy prefabs.
	private float time = 0;
	public float timeToIncrease = 10;
	private float playBackSpeed =1;




	void Start ()
	{
		// Start calling the Spawn function repeatedly after a delay .
		InvokeRepeating("Spawn",spawnTime,spawnDelay);
	}
	void Update ()
	{

		time += Time.deltaTime;

		if(time >= timeToIncrease)
		{
			timeToIncrease += timeToIncrease * .9f;
			spawnTime = spawnTime * .9f;
			spawnDelay = spawnDelay *.9f;
			playBackSpeed = playBackSpeed * 1.1f;

		}


	}


	void Spawn ()
	{
		GameObject currentObject;
		// Instantiate a random enemy.
		int platformsIndex = Random.Range(0, platforms.Length);
		currentObject = (GameObject)Instantiate(platforms[platformsIndex], transform.position, transform.rotation);

		currentObject.GetComponent<Animator>().speed = playBackSpeed;
		// Play the spawning effect from all of the particle systems.
		foreach(ParticleSystem p in GetComponentsInChildren<ParticleSystem>())
		{
			p.Play();
		}
	}
}
