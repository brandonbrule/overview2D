using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthController : MonoBehaviour {
	public GameObject Player;
	public GameObject HeartReference;
	public GameObject HealthUIContainer;
	private float Health = 0;
	private float LastPosition = 0;

	// Use this for initialization
	void Start () {
		InstanciateHealth();

		//Debug.Log(GameController.GetComponent<GameControl>().PlayerHealth);
	}

	public void removeHealth(float damage){

		float willDie = Health - damage;
		
		if(willDie <= 0){
			 SceneManager.LoadScene("overview");
		} else {
			Health = Health - damage;

			int totalHealth = HealthUIContainer.transform.childCount - 1;
			for (int i = 0; i < damage; i++){
				Destroy(HealthUIContainer.transform.GetChild(totalHealth).gameObject);
				totalHealth = totalHealth - 1;
				LastPosition = LastPosition - 20.0F;
	        }
		}

	}

	public void addHealth(float health){
		Health = Health + health;

		for (int i = 0; i < health; i++){
			LastPosition = LastPosition + 20.0F;
			GameObject HeartCopy = Instantiate(HeartReference, new Vector3 (LastPosition, 20, 0), Quaternion.identity);
			HeartCopy.transform.SetParent(HealthUIContainer.gameObject.transform);
        }
	}


	public void InstanciateHealth(){
		float StartingHealth = Player.GetComponent<Player>().health;
  		for (int i = 0; i < StartingHealth; i++)
        {
        	float loadHealth = 1;
        	addHealth(loadHealth);
        }
  	}
	
	// Update is called once per frame
	void Update () {
	}
}
