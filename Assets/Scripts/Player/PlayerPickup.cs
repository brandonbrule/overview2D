using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickup : MonoBehaviour {
	private GameObject UIContainerHealth;
	private GameObject UIContainerGems;
	private GameObject PlayerStateManager;
	private GameObject UIController;

	public int Worth;

	// Use this for initialization
	void Start () {
		UIContainerHealth = GameObject.Find("UI/HealthContainer");
		UIContainerGems = GameObject.Find("UI/GemsContainer");
		PlayerStateManager = GameObject.Find("Player/PlayerStateManager");
		UIController = GameObject.Find("UI");
	}

	// Remove Heart on Collide with Player
    void OnTriggerEnter2D(Collider2D other)
    {	


        if (other.gameObject.CompareTag("Player"))
        {
        	Worth = gameObject.GetComponent<PlayerPickup>().Worth;

        	if (gameObject.CompareTag("Health"))
	        {
	        	PlayerStateManager.GetComponent<PlayerState>().add(Worth, "Health");
            	UIController.GetComponent<UIController>().updateDisplay("Health");
	        }

	        if (gameObject.CompareTag("Gems"))
	        {
	    		PlayerStateManager.GetComponent<PlayerState>().add(Worth, "Gems");
	    		UIController.GetComponent<UIController>().updateDisplay("Gems");
	        }

         	Destroy(this.gameObject);
        }

    }
}
