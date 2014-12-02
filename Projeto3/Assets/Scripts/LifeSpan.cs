using UnityEngine;
using System.Collections;

public class LifeSpan : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	void LateUpdate () {
		if (transform.position.y < 0.0)
			Destroy(this.gameObject);
	}
}
