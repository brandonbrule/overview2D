using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour {

	public float health = 1;

	// Use this for initialization
	void Start () {
	}

	
	// Update is called once per frame
	void Update () {
		
	}

	// Remove Heart on Collide with Player
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
        }

    }
}
