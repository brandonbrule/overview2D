using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour {

    private GameObject GameController;
    public char direction;
    public char new_direction;
    private SpriteRenderer sprite;

    // Use this for initialization
    void Start () {
        GameController = GameObject.Find("GameController");
        direction = GameController.GetComponent<GameController>().PlayerDirection;
        sprite = gameObject.GetComponent<SpriteRenderer>();
        new_direction = direction;
    }
	
	// Update is called once per frame
	void FixedUpdate() {
        direction = GameController.GetComponent<GameController>().PlayerDirection;

        // Sword in front of you when facing down.
        if (direction == 'n')
        {
            sprite.sortingOrder = 0;
        }
        else
        {
            sprite.sortingOrder = 3;
        }

        
    }
}
