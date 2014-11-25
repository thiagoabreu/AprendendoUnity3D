using UnityEngine;
using System.Collections;

public class SpawnSpheres : MonoBehaviour {

	public float tempo;
	public Transform[] spawnPoints;
	public GameObject objeto;

	// Use this for initialization
	void Start () {
		InvokeRepeating("Spawn", tempo, tempo);
	}
	
	void Spawn() {
		int indice = Random.Range(0, spawnPoints.Length);

		Instantiate(objeto, spawnPoints[indice].position, spawnPoints[indice].rotation);
	}
}
