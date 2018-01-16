using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShield : MonoBehaviour {
    public GameObject TheShield;
	
	// Update is called once per frame
	void Update () {

        if (TheShield.GetComponent<Shield>().has_collided)
        {
            TheShield.SetActive(false);
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {

                TheShield.SetActive(true);
            }

            // If Attack is Held
            if (Input.GetKey(KeyCode.LeftShift))
            {
                TheShield.SetActive(true);
            }
            else
            {
                TheShield.SetActive(false);
            }
        }

    }
}
