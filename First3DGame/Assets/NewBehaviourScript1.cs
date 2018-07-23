using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour {

	public Rigidbody ball;
	int moveX;
	int moveY;
	int moveZ;


	// Use this for initialization
	void Start () {
		Debug.Log ("Begin\n");
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		ball.AddForce(0 + moveX, 0 + moveY, 0 + moveZ * Time.deltaTime);
	}
}
