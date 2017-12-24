using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickup : MonoBehaviour {
	private GameObject PlayerStateManager;
    private GameObject SoundController;
	private GameObject UIController;

	public int Worth;

	// Use this for initialization
	void Start () {
		PlayerStateManager = GameObject.Find("Player/PlayerStateManager");
        SoundController = GameObject.Find("SoundController");
        UIController = GameObject.Find("UI");
    }

	// Remove Heart on Collide with Player
    void OnTriggerEnter2D(Collider2D other)
    {	


        if (other.gameObject.CompareTag("Player"))
        {
        	Worth = gameObject.GetComponent<PlayerPickup>().Worth;
            SoundController.GetComponent<SoundController>().playSound(gameObject.tag);



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

         	Destroy(this.gameObject, 0.05f);
        }

    }
}
