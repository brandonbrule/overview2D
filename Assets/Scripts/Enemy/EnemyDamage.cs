using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour {
	public int damage = 1;
	private GameObject PlayerStateManager;
    private GameObject UIController;


	// Use this for initialization
	void Start () {
		PlayerStateManager = GameObject.Find("Player/PlayerStateManager");
		UIController = GameObject.Find("UI");
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D other)
    {


        if( other.gameObject.CompareTag("Player")){
            PlayerStateManager.GetComponent<PlayerState>().remove(damage, "Health");
            UIController.GetComponent<UIController>().updateDisplay("Health");
        }




    
        if (other.gameObject.CompareTag("Wall"))
        {

        }
    }
}
