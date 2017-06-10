using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthUI : MonoBehaviour {
	public GameObject Player;
	public GameObject Heart;
	public GameObject HealthUIContainer;
	private float Health = 1;

	// Use this for initialization
	void Start () {
		
		
		Debug.Log(HealthUIContainer);
		Debug.Log(Heart);
		Debug.Log(Health);

		createHeart();
		
	}


	public void createHeart(){
		Health = Player.GetComponent<Player>().health;
		
  		for (int i = 1; i < Health; i++)
        {
        	GameObject HeartCopy = Instantiate(Heart, new Vector3 (i * 20.0F, 20, 0), Quaternion.identity);
			 HeartCopy.transform.SetParent(HealthUIContainer.gameObject.transform);
			 //HeartCopy.Position.y = -20;
        }
  	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
