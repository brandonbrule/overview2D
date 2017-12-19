using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour {
	private GameObject GameController;
	public Text UITextHealth;
	public Text UITextGems;
	private int Health;
	private int Gems;
	private int MaxHealth;
	private int MaxGems;



	public void updateDisplay(string Type){
		Health = GameController.GetComponent<GameController>().Health;
		MaxHealth = GameController.GetComponent<GameController>().MaxHealth;
		Gems = GameController.GetComponent<GameController>().Gems;
		MaxGems = GameController.GetComponent<GameController>().MaxGems;

		if(Type == "Gems")
		{
			UITextGems.text = Gems.ToString() + "/" + MaxGems.ToString();
		}

		if(Type == "Health")
		{
			UITextHealth.text = Health.ToString() + "/" + MaxHealth.ToString();
		}
        
	}
	

	// Use this for initialization
	void Start () {
		GameController = GameObject.Find("GameController");

		updateDisplay("Health");
		updateDisplay("Gems");
		
	}

	
	// Update is called once per frame
	void Update () {

	}
}
