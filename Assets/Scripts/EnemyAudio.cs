using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAudio : MonoBehaviour {
    private GameObject SoundController;
    public AudioSource EnemySpawn;

    // Use this for initialization
    void Start () {
        SoundController = GameObject.Find("SoundController");
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
            SoundController.GetComponent<SoundController>().playSound("Damage");
        }

    }
}
