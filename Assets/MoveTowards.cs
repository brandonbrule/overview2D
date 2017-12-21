using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowards : MonoBehaviour {
    public Transform target;
    public float speed = 1f;
    private int direction = 0;
    public bool move = false;

    // Use this for initialization
    void Start () {

        // Face Direction on Start.
        // Only Up or Down from Target
        if(target.position.y > transform.position.y)
        {
            direction = 1;
        }

        if (target.position.y < transform.position.y)
        {
            direction = 3;
        }
    }

	
	// Decides if the target is left or right, top or bottom of object
    // Changes the direction accordingly
    // Rounded values are for lining up planes more accurately.
    // .1234 != .1235 but 1 == 1 Looks left right up or down.
	void FixedUpdate() {
        if (move)
        {
            float step = speed * Time.deltaTime;
            float target_x = Mathf.Round(target.position.x);
            float target_y = Mathf.Round(target.position.y);
            float transform_x = Mathf.Round(transform.position.x);
            float transform_y = Mathf.Round(transform.position.y);
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);

            
            if (target_x == transform_x && target.position.y > transform.position.y)
            {
                direction = 1;

            }
            else if (target_x == transform_x && target.position.y < transform.position.y)
            {
                direction = 3;

            }
            else if (target.position.x > transform.position.x && target_y == transform_y)
            {
                direction = 4;
                
            }
            else if (target.position.x < transform.position.x && target_y == transform_y)
            {
                direction = 2;
            } else
            {

            }

            this.gameObject.GetComponent<AnimationDirection>().setAnimationDirection(direction);

        }

    }

    // If you collide into specific things 
    // Stop moving for a moment
    public void ActivateMove()
    {
        move = true;
    }

    public void DectivateMove()
    {
        move = false;
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player" || other.tag == "Enemy")
        {
            move = false;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
            Invoke("ActivateMove", 0.25f);
        }
    }
}
