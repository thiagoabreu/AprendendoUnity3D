using UnityEngine;
using System.Collections;

public class FollowCamera : MonoBehaviour {

	public GameObject Player;

	private Vector3 offset;

	void Start () {
		offset = Player.transform.position + transform.position;
	}
	
	void LateUpdate () {
		transform.position = offset + Player.transform.position;
	}
}
