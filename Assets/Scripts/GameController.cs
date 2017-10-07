using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public static GameController control;
	public int Health;
	public int MaxHealth = 5;
	public int Gems;
	public int MaxGems = 50;
	public char PlayerDirection;
	public string ActiveScene;


	// Use this for initialization
	void Awake () {
		if(control == null){
			DontDestroyOnLoad(gameObject);
			control = this;
		} else if (control != this){
			Destroy(gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
