using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {
	public string SceneName;
	public string SceneLocation;
	public char EnterFromDirection = 'a';
	private char PlayerDirection;
	private GameObject GameController;

	// Use this for initialization
	void Start () {
		GameController = GameObject.Find("GameController");
		PlayerDirection = GameController.GetComponent<GameController>().PlayerDirection;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
        	PlayerDirection = GameController.GetComponent<GameController>().PlayerDirection;
        	GameController.GetComponent<GameController>().SceneName = SceneName;
        	GameController.GetComponent<GameController>().SceneLocation = SceneLocation;
        	if(EnterFromDirection == 'a' || EnterFromDirection == PlayerDirection){
            	SceneManager.LoadScene(SceneName);
        	}
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {

    }
}
