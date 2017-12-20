using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowards : MonoBehaviour {
    public Transform target;
    public float speed = 1f;

    private bool move;

    // Use this for initialization
    void Start () {
        move = true;

    }

	
	// Update is called once per frame
	void FixedUpdate() {
        if (move)
        {
            float step = speed * Time.deltaTime;
            float target_x = Mathf.Round(target.position.x);
            float target_y = Mathf.Round(target.position.y);
            float transform_x = Mathf.Round(transform.position.x);
            float transform_y = Mathf.Round(transform.position.y);
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);

            int direction = 0;
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

    void ActivateMove()
    {
        move = true;
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

        if (other.tag == "Player" || other.tag == "Enemy")
        {
            Invoke("ActivateMove", 0.25f);
        }
    }
}
