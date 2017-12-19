using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRandomly : MonoBehaviour{
    Animator anim;
    private int direction;
    public float speed;
    public float timeBetween = 3.0f;
    private float originalTimeBetween;

    // Use this for initialization
    void Start()
    {
        direction = Random.Range(1, 6);
        anim = GetComponent<Animator>();
        originalTimeBetween = timeBetween;
    }

    // Update is called once per frame
    void FixedUpdate()
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
            anim.SetFloat("input_x", 0);
            anim.SetFloat("input_y", 1);
        }

        else if (direction == 2)
        {
            transform.Translate(Vector3.left * (Time.deltaTime * speed), Space.World);
            anim.SetFloat("input_x", -1);
            anim.SetFloat("input_y", 0);
        }

        else if (direction == 3)
        {
            transform.Translate(Vector3.down * (Time.deltaTime * speed), Space.World);
            anim.SetFloat("input_x", 0);
            anim.SetFloat("input_y", -1);
        }

        else if (direction == 4)
        {
            transform.Translate(Vector3.right * (Time.deltaTime * speed), Space.World);
            anim.SetFloat("input_x", 1);
            anim.SetFloat("input_y", 0);
        }
        else
        {

        }

    }



    private void ChangeDirection()
    {
        direction = Random.Range(1, 6);
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if ( !gameObject.CompareTag("Health") || !gameObject.CompareTag("Gems"))
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
        }
    }
}
