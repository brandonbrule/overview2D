using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {
    private GameObject GameController;
    private GameObject SoundController;
    public GameObject PlayerActiveItem;
    private SpriteRenderer sprite;
    private char direction;
    Animator anim;

    void Start () {
        GameController = GameObject.Find("GameController");
        SoundController = GameObject.Find("SoundController");
        anim = GetComponent<Animator>();
        direction = GameController.GetComponent<GameController>().PlayerDirection;
        sprite = PlayerActiveItem.GetComponent<SpriteRenderer>();

         


    }
	
	// Update is called once per frame
	void Update () {
        userAttack();
    }

    void userAttack(){

        if (Input.GetKeyDown(KeyCode.Space)){
            anim.SetBool("isattacking", true);
            SoundController.GetComponent<SoundController>().playSound("PlayerSwordAttack");
        }

        // If Attack is Held
        if (Input.GetKey(KeyCode.Space))
        { 
            direction = GameController.GetComponent<GameController>().PlayerDirection;
            // Sword in front of you when facing down.
            if(direction == 's'){
                sprite.sortingOrder = 3;
            } else {
                sprite.sortingOrder = 2;
            }

        // If Attack is Released.    
        } else {
            PlayerActiveItem.SetActive(false);
            anim.SetBool("isattacking", false);
        }
        
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            // Radius is for Detection
            // Box Collider for Collisions
            if (other.GetType() is BoxCollider2D)
            {
                anim.SetBool("isattacking", false);
            }
        }


            
    }
}
