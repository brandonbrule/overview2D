using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour {

    private GameObject GameController;
    public char direction;
    public char old_direction;
    private SpriteRenderer sprite;

    // Use this for initialization
    void Start () {
        GameController = GameObject.Find("GameController");
        direction = GameController.GetComponent<GameController>().PlayerDirection;
        sprite = gameObject.GetComponent<SpriteRenderer>();
        old_direction = direction;
    }
	
	// Update is called once per frame
	void FixedUpdate() {
        direction = GameController.GetComponent<GameController>().PlayerDirection;


        if(direction != old_direction) {
            // Sword in front of you when facing down.
            if (direction == 'n' || direction == 'e')
            {
                sprite.sortingOrder = 0;
            }
            if(direction == 's' || direction == 'w')
            {
                sprite.sortingOrder = 3;
            }

            old_direction = direction;

        }


    }
}
