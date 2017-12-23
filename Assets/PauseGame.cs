using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour {
    public bool isPaused = false;

    // Use this for initialization
    void Start()
    {
        if (isPaused)
        {
            Time.timeScale = 0F;
        }
    }

	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.P))
        {
 
            if (isPaused)
            {
                Time.timeScale = 1.0F;
                Time.fixedDeltaTime = 0.02F * Time.timeScale;
                isPaused = false;
                
            }
            else
            {
                Time.timeScale = 0F;
                isPaused = true;
            }
                
        }
    }
}
