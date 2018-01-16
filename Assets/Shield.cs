using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour {

    private GameObject GameController;
    public char direction;
    public char old_direction;
    private SpriteRenderer sprite;
    public GameObject TheShield;
    public bool has_collided = false;

    // Use this for initialization
    void Start () {
        GameController = GameObject.Find("GameController");
        direction = GameController.GetComponent<GameController>().PlayerDirection;
        sprite = TheShield.GetComponent<SpriteRenderer>();
        old_direction = direction;
    }

    // Facing Down, Layer Order In Front, Facing Up, Layer Order Behind
    void setSpriteOrder()
    {
        direction = GameController.GetComponent<GameController>().PlayerDirection;
        if (direction != old_direction)
        {
            // Sword in front of you when facing down.
            if (direction == 'n' || direction == 'e')
            {
                sprite.sortingOrder = 0;
            }
            if (direction == 's' || direction == 'w')
            {
                sprite.sortingOrder = 3;
            }

            old_direction = direction;

        }
    }



    // If collision of enemy detected
    // Deactivate Shield With Timer To Reactivate
    void resetShield()
    {
        has_collided = false;
    }

    void shieldCollision()
    {
        has_collided = true;
        TheShield.SetActive(true);
        Invoke("resetShield", 0.5f);
    }

    // Update is called once per frame
    void FixedUpdate() {
        setSpriteOrder();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            if (other.gameObject.GetComponent<EnemyDamage>().shieldStunTime > 0)
            {
                shieldCollision();
            }
        }
    }
}
