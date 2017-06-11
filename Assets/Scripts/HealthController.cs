using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour {

	public GameObject Player;
	public GameObject Heart;
	public GameObject HealthUIContainer;
	private float Health = 1;
	private float LastPosition = 0;

	// Use this for initialization
	void Start () {
		InstanciateHealth();
	}

	public void removeHealth(float damage){
		int totalHealth = HealthUIContainer.transform.childCount - 1;


		for (int i = 0; i < damage; i++){
			Debug.Log("Damage");
			Destroy(HealthUIContainer.transform.GetChild(totalHealth).gameObject);
			totalHealth = totalHealth - 1;
			LastPosition = LastPosition - 20.0F;
        }
	}

	public void addHealth(float health){
		for (int i = 0; i < health; i++){
			LastPosition = LastPosition + 20.0F;
			GameObject HeartCopy = Instantiate(Heart, new Vector3 (LastPosition, 20, 0), Quaternion.identity);
			HeartCopy.transform.SetParent(HealthUIContainer.gameObject.transform);
        }
	}


	public void InstanciateHealth(){
		Health = Player.GetComponent<Player>().health;
		
  		for (int i = 0; i < Health; i++)
        {
        	addHealth(1);
        }
  	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
