using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveItemDamage : MonoBehaviour {
    private GameObject Player;
    private GameObject SoundController;
    Animator anim;
    public int damage;

    void Start()
    {
        SoundController = GameObject.Find("SoundController");
        Player = GameObject.Find("Player");
        anim = Player.GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (!other.gameObject.CompareTag("Untagged") && !other.gameObject.CompareTag("Gems") && !other.gameObject.CompareTag("Health"))
        {
            // Retract Attack when with any collission for now.
            if (other.gameObject.CompareTag("Enemy"))
            {
                SoundController.GetComponent<SoundController>().playSound("Damage");
            } else
            {
                SoundController.GetComponent<SoundController>().playSound("PlayerSwordCollision");
            }

            this.gameObject.SetActive(false);
            anim.SetBool("isattacking", false);

        }

    }
}
