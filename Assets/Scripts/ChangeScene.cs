using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {
	public string WarpTo;
	public char EnterFromDirection = 'a';
	private char PlayerDirection;
	public bool StartOnSceneChange = false;
	private GameObject GameController;

	// Use this for initialization
	void Start () {
		StartOnSceneChange = true;
		GameController = GameObject.Find("GameController");
		PlayerDirection = GameController.GetComponent<GameController>().PlayerDirection;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") && StartOnSceneChange == false)
        {
        	PlayerDirection = GameController.GetComponent<GameController>().PlayerDirection;
        	if(EnterFromDirection == 'a' || EnterFromDirection == PlayerDirection){
            	SceneManager.LoadScene(WarpTo);
        	}
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        StartOnSceneChange = false;
    }
}
