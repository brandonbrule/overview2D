using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Transform target;
    Camera playerCam;
    public float c_speed = 0.1f;

	// Use this for initialization
	void Start () {
        playerCam = GetComponent<Camera> ();
	}
	
	// Update is called once per frame
	void LateUpdate () {
        playerCam.orthographicSize = (Screen.height / 100f) / 2f;

        if (target){
        	transform.position = Vector3.Lerp(transform.position, target.position, c_speed) + new Vector3(0,0,-10);
        }
		
	}
}
