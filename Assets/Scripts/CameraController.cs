using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Transform target;
    Camera playerCam;
    public float c_speed = 0.1f;
    public float c_zoom = 4f;

	// Use this for initialization
	void Start () {
        playerCam = GetComponent<Camera> ();
	}
	
	// Update is called once per frame
	void LateUpdate () {
        //playerCam.orthographicSize = (Screen.height / 100f) / c_zoom;
        //playerCam.orthographicSize = Screen.width / (((Screen.width / Screen.height) * 2) * 100);
        //Debug.Log(Screen.width / (((Screen.width / Screen.height) * 2) * 100));

        if (target){
        	transform.position = Vector3.Lerp(transform.position, target.position, c_speed) + new Vector3(0,0,-10);
        }
		
	}
}
