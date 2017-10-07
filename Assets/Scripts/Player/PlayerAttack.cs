using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {
    public GameObject PlayerActiveItem;
    private GameObject GameController;
    private char direction;
    Animator anim;

    void Start () {
        GameController = GameObject.Find("GameController");
        anim = GetComponent<Animator>();
        direction = GameController.GetComponent<GameController>().PlayerDirection;


         


    }
	
	// Update is called once per frame
	void Update () {
        userAttack();
    }

    void userAttack(){
        if (Input.GetKeyDown(KeyCode.Space)) //set the key you want to be pressed
        { 
            anim.SetBool("isattacking", true);
            PlayerActiveItem.SetActive(true);
        }

        if (Input.GetKeyUp(KeyCode.Space)) //set the key you want to be pressed
        {

Debug.Log(PlayerActiveItem.transform.position);
PlayerActiveItem.transform.position = new Vector3(17.0f, 7.0f, 7.0f);
Debug.Log(PlayerActiveItem.transform.position);
PlayerActiveItem.transform.Rotate(0,45,0);


            PlayerActiveItem.SetActive(false);
            anim.SetBool("isattacking", false);
        }

        
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log(other);
        if (other.gameObject.CompareTag("Chest"))
        {
            other.gameObject.SetActive(false);
        }
    }
}
