using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour {
	public string WarpTo;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log(other);
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Cha-Ching");
            SceneManager.LoadScene(WarpTo);
        }
    }
}
