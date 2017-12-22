using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationDirection : MonoBehaviour {
    Animator anim;
    private int Health;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
    }

    public void setAnimationDirection(int direction)
    {
        if (anim)
        {
            if (direction == 1)
            {
                anim.SetFloat("input_x", 0);
                anim.SetFloat("input_y", 1);
            }

            else if (direction == 2)
            {
                anim.SetFloat("input_x", -1);
                anim.SetFloat("input_y", 0);
            }

            else if (direction == 3)
            {
                anim.SetFloat("input_x", 0);
                anim.SetFloat("input_y", -1);
            }

            else if (direction == 4)
            {
                anim.SetFloat("input_x", 1);
                anim.SetFloat("input_y", 0);
            }
            else
            {

            }
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
