using UnityEngine;
using System.Collections;

public class ControleDeJogador : MonoBehaviour {

	public float speed;

	void FixedUpdate () {
		float moveVertical = Input.GetAxis("Vertical");
		var movement = new Vector3(0, moveVertical, 0);

		rigidbody.AddRelativeForce(movement * speed * Time.deltaTime);

		float rotateHorizontal = Input.GetAxis("Horizontal");
		var rotation = new Vector3(0, rotateHorizontal, 0);

		transform.RotateAround(transform.position, Vector3.up, rotateHorizontal);

	}
}
