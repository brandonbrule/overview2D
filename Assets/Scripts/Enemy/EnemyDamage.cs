using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour {
	public int damage = 1;
    public bool destroyable;
	private GameObject PlayerManager;
    private GameObject UIController;


	// Use this for initialization
	void Start () {
		PlayerManager = GameObject.Find("Player/PlayerManager");
		UIController = GameObject.Find("UI");
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D other)
    {


        if( other.gameObject.CompareTag("Player")){
            PlayerManager.GetComponent<PlayerState>().remove(damage, "Health");
            UIController.GetComponent<UIController>().updateDisplay("Health");
        }



        if (other.gameObject.CompareTag("ActiveItem"))
        {
            if(destroyable == true){
                Destroy(this.gameObject);
            }
            Debug.Log(other.gameObject);
            //Destroy(this.gameObject);
        }


    
        if (other.gameObject.CompareTag("Wall"))
        {
            
            //Debug.Log(direction);
            
            //Debug.Log("Wall");
        }
    }
}
