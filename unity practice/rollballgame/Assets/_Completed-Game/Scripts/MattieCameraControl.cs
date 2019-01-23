using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MattieCameraControl : MonoBehaviour {
// we want the camera to be a little ways away from the player and not rotate like im being thrown into a washing machine


	public GameObject player;

	//offset private so it cant be touched in the editor i think???
	private Vector3 offset;


	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}

	// Update is called once per frame
	void LateUpdate () {
		//late update makes it so that the camera updates after the player has moved, for sure
		transform.position = player.transform.position + offset;
	}
}
