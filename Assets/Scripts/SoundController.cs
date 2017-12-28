using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour {
    public AudioSource GemsPickup;
    public AudioSource GemsDropped;
    public AudioSource HealthPickup;
    public AudioSource PlayerDamaged;
    public AudioSource PlayerSwordAttack;
    public AudioSource PlayerSwordCollision;
    public AudioSource Walking;
    public AudioSource PauseGame;
    public AudioSource Damage;
    public AudioSource BackgroundMusic;
    public AudioSource EnemyDeath;
    public AudioSource GameOver;

    public void stopSound(string tag)
    {
        if (tag == "Gems" && GemsPickup)
        {
            GemsPickup.Stop();
        }

        if (tag == "Health" && HealthPickup)
        {
            HealthPickup.Stop();
        }

        if (tag == "Walking" && Walking)
        {
                Walking.Stop();
        }

        if (tag == "BackgroundMusic" && BackgroundMusic)
        {
            BackgroundMusic.Stop();
        }
    }

    public void playSound(string tag)
    {
        

        if (tag == "Walking" && Walking)
        {
            if (!Walking.isPlaying)
            {
                Walking.Play();
            }
            
        }


        if (tag == "Damage" && Damage)
        {
            Damage.Play();
        }

        if (tag == "PlayerSwordAttack" && PlayerSwordAttack)
        {
            PlayerSwordAttack.Play();
        }

        if (tag == "PlayerSwordCollision" && PlayerSwordCollision)
        {
            PlayerSwordCollision.Play();
        }
        
        if(tag == "PlayerDamaged" && PlayerDamaged)
        {
            PlayerDamaged.Play();
        }

        if (tag == "Gems" && GemsPickup)
        {
            GemsPickup.Play();
        }

        if (tag == "GemsDropped" && GemsDropped)
        {
            GemsDropped.Play();
        }

        if (tag == "Health" && HealthPickup)
        {
            HealthPickup.Play();
        }

        if (tag == "EnemyDeath" && EnemyDeath)
        {
            EnemyDeath.Play();
        }

        if (tag == "PauseGame" && PauseGame)
        {
            PauseGame.Play();
        }

        if (tag == "GameOver" && GameOver)
        {
            GameOver.Play();
        }

        if (tag == "BackgroundMusic" && BackgroundMusic)
        {
            BackgroundMusic.Play();
        }

        


    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
