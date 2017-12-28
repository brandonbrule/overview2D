using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour {
    private GameObject SoundController;
    private GameObject PlayerStateManager;
    private GameObject UIController;
    private GameObject Player;
    
    public int damage = 1;
    public int pushback = 0;
	


	// Use this for initialization
	void Start () {
        Player = GameObject.Find("Player");
        PlayerStateManager = GameObject.Find("Player/PlayerStateManager");
        SoundController = GameObject.Find("SoundController");
        UIController = GameObject.Find("UI");
	}
	
    void stopPushback()
    {
        Player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        Player.GetComponent<Rigidbody2D>().angularVelocity = 0;
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

            Invoke("stopPushback", 0.05f);
        }

    }
}
