using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour {
    private GameObject SoundController;
    private GameObject PlayerStateManager;
    private GameObject UIController;
    
    public int damage = 1;
    public int pushback = 0;
	


	// Use this for initialization
	void Start () {
		PlayerStateManager = GameObject.Find("Player/PlayerStateManager");
        SoundController = GameObject.Find("SoundController");
        UIController = GameObject.Find("UI");
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D other)
    {


        if( other.gameObject.CompareTag("Player")){

            SoundController.GetComponent<SoundController>().playSound("PlayerDamaged");

            PlayerStateManager.GetComponent<PlayerState>().remove(damage, "Health");
            UIController.GetComponent<UIController>().updateDisplay("Health");

            var force = transform.position - other.transform.position;
            force.Normalize();
            other.gameObject.GetComponent<Rigidbody2D>().AddForce(-force * pushback);
        }

    }
}
