using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public GameObject HealthUI;
    public float health = 10;


    // Use this for initialization
    void Start () {
    }
	

	// Update is called once per frame
	void Update () {
    }


    // Player Has Colided with
    void OnTriggerEnter2D(Collider2D other)
    {

        Debug.Log(other.gameObject.tag);

        //Debug.Log(other.gameObject);
        if (other.gameObject.CompareTag("Enemy"))
        {
            float damage = other.gameObject.GetComponent<Enemy>().damage;
            HealthUI.GetComponent<HealthController>().removeHealth(damage);
        }

        if (other.gameObject.CompareTag("Health"))
        {

            float health = other.gameObject.GetComponent<HealthPickup>().health;
            HealthUI.GetComponent<HealthController>().addHealth(health);
        }

    }
}
