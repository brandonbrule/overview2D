using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerState : MonoBehaviour {
	private int Health;
	private int MaxHealth;
	private int Gems;
	private int MaxGems;
	private string PlayerActiveItem;
	private GameObject GameController;

	// Use this for initialization
	void Start () {
		GameController = GameObject.Find("GameController");
		Health = GameController.GetComponent<GameController>().Health;
		MaxHealth = GameController.GetComponent<GameController>().MaxHealth;
		Gems = GameController.GetComponent<GameController>().Gems;
		MaxGems = GameController.GetComponent<GameController>().MaxGems;

		Scene scene = SceneManager.GetActiveScene();
		GameController.GetComponent<GameController>().ActiveScene = scene.name;
	}

	public void updateDirection(char direction){
		GameController.GetComponent<GameController>().PlayerDirection = direction;
	}

	public void add(int Worth, string Type){

		if(Type == "Gems")
		{
			if(Gems < MaxGems)
			{
				Gems = Gems + Worth;
				GameController.GetComponent<GameController>().Gems = Gems;
			} else {
				GameController.GetComponent<GameController>().Gems = MaxGems;
			}
		}

		if(Type == "Health")
		{
			if(Health < MaxHealth)
			{
				Health = Health + Worth;
				GameController.GetComponent<GameController>().Health = Health;
			}
		}

	}


	public void remove(int Worth, string Type){

		if(Type == "Gems")
		{
			Gems = Gems - Worth;
			GameController.GetComponent<GameController>().Gems = Gems;
		}

		if(Type == "Health")
		{
			Health = Health - Worth;
			GameController.GetComponent<GameController>().Health = Health;
			
			if(Health <= 0){
				GameController.GetComponent<GameController>().Health = MaxHealth;
				SceneManager.LoadScene("overview");
			}

		}

	}
	
}
