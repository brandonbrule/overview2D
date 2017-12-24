using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour {
    private GameObject SoundController;
    public bool isPaused = false;
    public GameObject screen;

    // Use this for initialization
    void Start()
    {
        SoundController = GameObject.Find("SoundController");

        if (isPaused)
        {
            Time.timeScale = 0F;
        } else
        {
            screen.SetActive(false);
        }
    }

	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.P))
        {

            SoundController.GetComponent<SoundController>().playSound("PauseGame");

            if (isPaused)
            {
                Time.timeScale = 1.0F;
                Time.fixedDeltaTime = 0.02F * Time.timeScale;
                isPaused = false;
                screen.SetActive(false);
                SoundController.GetComponent<SoundController>().playSound("BackgroundMusic");
            }
            else
            {
                Time.timeScale = 0F;
                isPaused = true;
                screen.SetActive(true);
                SoundController.GetComponent<SoundController>().stopSound("BackgroundMusic");
            }
                
        }
    }
}
