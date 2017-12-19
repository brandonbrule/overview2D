using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRandomly : MonoBehaviour
{

    Rigidbody2D rbody;
    private int direction;
    public float speed;
    public float timeBetween = 3.0f;

    // Use this for initialization
    void Start()
    {
        direction = Random.Range(1, 5);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timeBetween -= Time.deltaTime;
        if (timeBetween <= 0.0f)
        {

            ChangeDirection();
            timeBetween = 1.0f;
        }
        if (direction == 1)
        {
            transform.Translate(Vector3.up * (Time.deltaTime * speed), Space.World);
        }

        if (direction == 2)
        {
            transform.Translate(Vector3.left * (Time.deltaTime * speed), Space.World);
        }

        if (direction == 3)
        {
            transform.Translate(Vector3.down * (Time.deltaTime * speed), Space.World);
        }

        if (direction == 4)
        {
            transform.Translate(Vector3.right * (Time.deltaTime * speed), Space.World);
        }


    }



    private void ChangeDirection()
    {

        direction = Random.Range(1, 5);
        

        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(direction);
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
        Debug.Log(direction);
    }
}
