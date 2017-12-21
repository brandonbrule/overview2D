using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRandomly : MonoBehaviour{
    private int direction;
    public float speed;
    public float timeBetween = 3.0f;
    private float originalTimeBetween;
    private bool setFirstDirection = true;
    private bool move = true;

    void Start()
    {
        direction = Random.Range(1, 6);
        originalTimeBetween = timeBetween;
        this.gameObject.GetComponent<AnimationDirection>().setAnimationDirection(direction);
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

    void FixedUpdate()
    {
        if (move)
        {
            timeBetween -= Time.deltaTime;
            if (timeBetween <= 0.0f)
            {

                ChangeDirection();
                timeBetween = originalTimeBetween;
            }
            if (direction == 1)
            {
                transform.Translate(Vector3.up * (Time.deltaTime * speed), Space.World);
            }

            else if (direction == 2)
            {
                transform.Translate(Vector3.left * (Time.deltaTime * speed), Space.World);
            }

            else if (direction == 3)
            {
                transform.Translate(Vector3.down * (Time.deltaTime * speed), Space.World);
            }

            else if (direction == 4)
            {
                transform.Translate(Vector3.right * (Time.deltaTime * speed), Space.World);
            }
            else
            {

            }
        }

        // Set the animation direction
        // On first direction change
        if (setFirstDirection)
        {
            this.gameObject.GetComponent<AnimationDirection>().setAnimationDirection(direction);
        }
        // Dont do this again,
        // Only on changeDirection
        // Which has timer
        setFirstDirection = false;

    }


    private void ChangeDirection()
    {
        direction = Random.Range(1, 6);
        this.gameObject.GetComponent<AnimationDirection>().setAnimationDirection(direction);
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        // Turn Around if collides into other objects.
        // Walk over Health and Gems
        if (other.tag != "Health" && other.tag != "Gems" )
        {
        
            if (direction == 1)
            {
                direction = 3;
            }
            else if (direction == 2)
            {
                direction = 4;
           
            }
            else if (direction == 3)
            {
                direction = 1;
            }

            else if (direction == 4)
            {
                direction = 2;
            }
            else
            {

            }

            this.gameObject.GetComponent<AnimationDirection>().setAnimationDirection(direction);
        }
    }
}
